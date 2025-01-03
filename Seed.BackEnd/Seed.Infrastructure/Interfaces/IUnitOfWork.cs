using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IEmailTemplateRepository EmailTemplateRepository { get; }
        int Complete();
    }
}
