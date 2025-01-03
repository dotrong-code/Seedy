using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seed.Domain.Entities;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class EmailTemplateRepository : GenericRepository<EmailTemplate>, IEmailTemplateRepository
    {
        public EmailTemplateRepository(SeedContext context) : base(context) { }
        public async Task<EmailTemplate> GetEmailTemplateByTypeAsync(string type)
        {
            return await _context.EmailTemplates.FirstOrDefaultAsync(et => et.Type == type);
        }

        public async Task<dynamic> SaveEmailSending(UserEmail userEmail)
        {
            _context.UserEmails.Add(userEmail);
            return await _context.SaveChangesAsync();
        }
        public async Task AddEmailTemplateAsync(EmailTemplate emailTemplate)
        {
            await _context.EmailTemplates.AddAsync(emailTemplate);
            await _context.SaveChangesAsync();
        }
    }
}
