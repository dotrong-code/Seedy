using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;
using Seed.Domain.Entities;

namespace Seed.Application.Interface.IService
{
    public interface IEmailTemplateService
    {
        Task<string> GenerateEmailBody(string emailTemplateType, Dictionary<string, string> placeholders);
        Task<dynamic> SendMail(MailObject mailObject);
        Task<Result> SaveEmailTemplateAsync(EmailTemplate emailTemplate);
        Task<Result> GetTemplateByTypeAsync(string templateType);
        Task<Result> GenerateEmailWithActivationLink(string templateType, string activationLink, Dictionary<string, string> additionalPlaceholders = null);
        Task<Result> GenerateEmailWithAppointmentLink(string templateType, string activationLink, Dictionary<string, string> additionalPlaceholders = null);
        Task<Result> GenerateEmailForAppointmentStatusAsync(string templateType, string status, string appointmentDetailUrl, Dictionary<string, string> placeholders);

    }
}
