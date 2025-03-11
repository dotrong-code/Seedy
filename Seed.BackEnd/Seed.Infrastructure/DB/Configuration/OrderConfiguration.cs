using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                 new Order
                 {
                     Id = new Guid("7bed677a-0413-4d17-9a3d-4c7c09e43dcb"),
                     UserID = new Guid("bfa4ee73-f13b-487c-8fd4-0e074725d2dd"),
                     ReceiverFullName = "John Doe",
                     ReceiverAddress = "123 Main St, City, Country",
                     ReceiverPhone = "0987654321",
                     ReceiverEmail = "quocthangjk@gmail.com",
                     ReceiverWard = 5,
                     WardName = "Ward 5", // New Field
                     ReceiverDistrict = 2,
                     DistrictName = "District 2", // New Field
                     ReceiverProvince = 1,
                     ProvinceName = "Province 1", // New Field
                     TotalPrice = 500000,
                     ShippingFee = 10000,
                     OrderService = "Express Delivery",
                     OrderNote = "Please handle with care",
                     MoneyCollection = 597000
                 },
                 new Order
                 {
                     Id = new Guid("582802e3-ff45-453b-acea-2219784402a9"),
                     UserID = new Guid("bfa4ee73-f13b-487c-8fd4-0e074725d2dd"),
                     ReceiverFullName = "John Doe",
                     ReceiverAddress = "123 Main St, City, Country",
                     ReceiverPhone = "0987654321",
                     ReceiverEmail = "quocthangjk@gmail.com",
                     ReceiverWard = 5,
                     WardName = "Ward 5", // New Field
                     ReceiverDistrict = 2,
                     DistrictName = "District 2", // New Field
                     ReceiverProvince = 1,
                     ProvinceName = "Province 1", // New Field
                     TotalPrice = 400000,
                     ShippingFee = 15000,
                     OrderService = "Express Delivery",
                     OrderNote = "Please handle with care",
                     MoneyCollection = 597000
                 }
                );
        }
    }
}
