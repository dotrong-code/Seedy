using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
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
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<UserEmail> UserEmails { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Role> Roles { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            #region Entity Configurations
            #endregion
            #region Table Mappings
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<EmailTemplate>().ToTable("EmailTemplate");
            modelBuilder.Entity<UserEmail>().ToTable("UserEmail");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<Cart>().ToTable("Cart");
            modelBuilder.Entity<CartItem>().ToTable("CartItem");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<Message>().ToTable("Message");
            #endregion
            #region Relationships and Additional Configuration
            #endregion
        }
    }
}
