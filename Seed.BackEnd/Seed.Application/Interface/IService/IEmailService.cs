using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Application.Interface.IService
{
    public interface IEmailService
    {
        public Task<bool> SendAccountActivationEmailAsync(string toEmail, string userName, string activationLink);
        //Task<string> SendForgetPasswordEmail(string toEmail, string userName, string resetLink);

        //public Task<string> SendAccountActivationEmail(string toEmail, string userName, string activationLink);

    }
}
