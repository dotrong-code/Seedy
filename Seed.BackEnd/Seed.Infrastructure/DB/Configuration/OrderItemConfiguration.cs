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
                    ProductId = new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"),
                    Quantity = 10,
                    Price = 10,

                },
                new OrderItem
                {
                    OrderId = new Guid("582802e3-ff45-453b-acea-2219784402a9"),
                    ProductId = new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"),
                    Quantity = 10,
                    Price = 10,
                }

                );
        }
    }
}
