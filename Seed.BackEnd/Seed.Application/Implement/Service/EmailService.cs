using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Application.Implement.Service
{
    public class EmailService : IEmailService
    {
        private readonly IEmailTemplateRepository _emailTemplateRepository;
        private readonly IConfiguration _configuration;

        public EmailService(IEmailTemplateRepository emailTemplateRepository, IConfiguration configuration)
        {
            _emailTemplateRepository = emailTemplateRepository;
            _configuration = configuration;
        }

        public async Task<bool> SendAccountActivationEmailAsync(string toEmail, string userName, string activationLink)
        {
            var template = await _emailTemplateRepository.GetEmailTemplateByTypeAsync("AccountActivation");
            if (template == null)
            {
                throw new Exception("Account Activation email template not found.");
            }

            // Replace placeholders
            var body = template.Body
        .Replace("{ActivationLink}", activationLink);


            return await SendEmailAsync(toEmail, template.Subject, body);
        }

        private async Task<bool> SendEmailAsync(string toEmail, string subject, string body)
        {
            try
            {
                var mailSender = _configuration["MailService:MailSender"];
                var passwordSender = _configuration["MailService:PasswordSender"];
                var smtpServer = _configuration["SMTP:Server"];
                var smtpPort = int.Parse(_configuration["SMTP:Port"]);

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(mailSender),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(new MailAddress(toEmail));

                using (var smtpClient = new SmtpClient(smtpServer, smtpPort))
                {
                    smtpClient.Credentials = new NetworkCredential(mailSender, passwordSender);
                    smtpClient.EnableSsl = true;
                    await smtpClient.SendMailAsync(mailMessage);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Email sending failed: {ex.Message}");
                return false;
            }
        }
    }
}
