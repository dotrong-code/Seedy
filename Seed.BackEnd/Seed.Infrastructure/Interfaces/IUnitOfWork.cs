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
        IFirebaseRepository FirebaseRepository { get; }
        IProductCategoryRepository ProductCategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        ICartItemRepository CartItemRepository { get; }
        ICartRepository CartRepository { get; }
        IOrderItemRepository OrderItemRepository { get; } 
        IOrderRepository OrderRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        int Complete();
        Task<int> SaveChangesAsync();
    }
}
