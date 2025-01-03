using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IEmailTemplateRepository : IGenericRepository<EmailTemplate>
    {
        public Task<EmailTemplate> GetEmailTemplateByTypeAsync(string type);


        public Task<dynamic> SaveEmailSending(UserEmail userEmail);
        public Task AddEmailTemplateAsync(EmailTemplate emailTemplate);
    }
}
