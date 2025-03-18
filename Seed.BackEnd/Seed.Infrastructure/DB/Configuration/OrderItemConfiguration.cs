using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(
                new OrderItem
                {
                    OrderId = new Guid("7bed677a-0413-4d17-9a3d-4c7c09e43dcb"),
                    ProductId = new Guid("d0aea562-6c4b-4d0c-baa7-323c53e2440e"),
                    Quantity = 2,
                    Price = 29000.0m,

                },
                new OrderItem
                {
                    OrderId = new Guid("582802e3-ff45-453b-acea-2219784402a9"),
                    ProductId = new Guid("d5f5a53c-2bad-420f-aa89-38ad16a09a09"),
                    Quantity = 2,
                    Price = 25000.0m,
                }

                );
        }
    }
}
