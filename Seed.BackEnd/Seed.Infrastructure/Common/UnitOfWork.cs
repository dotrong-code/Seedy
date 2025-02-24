using Google.Cloud.Storage.V1;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.Implement.Repositories;
using Seed.Infrastructure.Interfaces;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SeedContext _context;

        public IUserRepository UserRepository { get; private set; }

        public IOrderRepository OrderRepository { get; private set; }
        public IOrderItemRepository OrderItemRepository { get; private set; }
        public IOrderTrackingRepository OrderTrackingRepository { get; private set; }
        public IPaymentRepository PaymentRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public IProductCategoryRepository ProductCategoryRepository { get; private set; }
        public ICartRepository CartRepository { get; private set; }
        public ICartItemRepository CartItemRepository { get; private set; }
        public IEmailTemplateRepository EmailTemplateRepository { get; private set; }
        public IFirebaseRepository FirebaseRepository { get; private set; }
        public ISetRepository SetRepository { get; private set; }

        public UnitOfWork(SeedContext context, StorageClient storageClient)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
            CartRepository = new CartRepository(_context);
            CartItemRepository = new CartItemRepository(_context);
            OrderRepository = new OrderRepository(_context);
            OrderItemRepository = new OrderItemRepository(_context);
            PaymentRepository = new PaymentRepository(_context);
            ProductRepository = new ProductRepository(_context);
            OrderTrackingRepository = new OrderTrackingRepository(_context);
            PaymentRepository = new PaymentRepository(_context);
            FirebaseRepository = new FirebaseRepository(storageClient);
            ProductCategoryRepository = new ProductCategoryRepository(_context);
            EmailTemplateRepository = new EmailTemplateRepository(_context);
            SetRepository = new SetRepository(_context);

        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
