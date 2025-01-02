using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Domain.Entities;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class EmailTemplateRepository : GenericRepository<EmailTemplate>, IEmailTemplateRepository
    {
        public EmailTemplateRepository(SeedContext context) : base(context) { }
    }
}
