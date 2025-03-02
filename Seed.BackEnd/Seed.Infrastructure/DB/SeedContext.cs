using Microsoft.EntityFrameworkCore;
using Seed.Domain.Entities;
using Seed.Infrastructure.DB.Configuration;

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
        public DbSet<OrderTracking> OrderTrackings { get; set; }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; } // Added ProductCategory DbSet
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<UserEmail> UserEmails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PointsHistory> PointsHistorys { get; set; }
        public DbSet<SetProduct> SetProducts { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Occasion> Occasions { get; set; }


        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Entity Configurations
            modelBuilder.ApplyConfiguration(new EmailTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new OccasionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SetConfiguration());
            modelBuilder.ApplyConfiguration(new SetProductConfiguration());

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
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<PointsHistory>().ToTable("PointsHistory");
            modelBuilder.Entity<OrderTracking>().ToTable("OrderTracking");
            modelBuilder.Entity<SetProduct>().ToTable("SetProduct");
            modelBuilder.Entity<Set>().ToTable("Set");
            modelBuilder.Entity<Occasion>().ToTable("Occasion");

            #endregion
            #region Relationships and Additional Configuration
            //UserEmail

            modelBuilder.Entity<UserEmail>()
                .HasKey(ue => new { ue.UserID, ue.EmailTemplateId });

            modelBuilder.Entity<UserEmail>()
                .HasOne(ue => ue.User)
                .WithMany(u => u.UserEmails)
                .HasForeignKey(ue => ue.UserID);

            modelBuilder.Entity<UserEmail>()
                .HasOne(ue => ue.EmailTemplate)
                .WithMany(c => c.UserEmails)
                .HasForeignKey(ue => ue.EmailTemplateId);
            // Cart relationships
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany(u => u.Carts)
                .HasForeignKey(c => c.UserID)
                .OnDelete(DeleteBehavior.SetNull);

            // CartItem relationships
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.SetNull);

            // Order relationships
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserID)
                .OnDelete(DeleteBehavior.SetNull);

            // OrderItem relationships
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.SetNull);


            // Payment relationships
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.User)
                .WithMany(u => u.Payments)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);



            // PointsHistory relationships
            modelBuilder.Entity<PointsHistory>()
                .HasOne(ph => ph.User)
                .WithMany(u => u.PointsHistories)
                .HasForeignKey(ph => ph.UserID)
                .OnDelete(DeleteBehavior.SetNull);

            // Product relationships
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductCategory)
                .WithMany(pc => pc.Products)
                .HasForeignKey(p => p.ProductCategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<SetProduct>()
            .HasKey(sp => new { sp.SetId, sp.ProductId });

            modelBuilder.Entity<SetProduct>()
                .HasOne(sp => sp.Set)
                .WithMany(s => s.SetProducts)
                .HasForeignKey(sp => sp.SetId)
                 .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<SetProduct>()
                .HasOne(sp => sp.Product)
                .WithMany(p => p.SetProducts)
                .HasForeignKey(sp => sp.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Occasion>()
                .HasMany(o => o.Sets)
                .WithOne(s => s.Occasion)
                .HasForeignKey(s => s.OccasionId)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Occasion)
                .WithMany(o => o.Products)
                .HasForeignKey(p => p.OccasionId)
                .OnDelete(DeleteBehavior.SetNull);

            #endregion
        }
    }
}
