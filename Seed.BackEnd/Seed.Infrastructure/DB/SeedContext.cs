using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB
{
    public class SeedContext : DbContext
    {
        public SeedContext() { }
        public SeedContext(DbContextOptions<SeedContext> options) : base(options) { }
        #region DBSet
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; } // Added ProductCategory DbSet

        #endregion

    }
}
