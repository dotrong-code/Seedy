using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = new Guid("d0aea562-6c4b-4d0c-baa7-323c53e2440e"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("05baa743-b4c3-450c-8b98-ae9b9e78df8c"),
                    Note = "BỘ SƯU TẬP \"SEEDY\"",
                    Name = "THIỆP “GIỐNG\"",
                    Description = "THIỆP “GIỐNG\"",
                    Price = 29000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/11f4ac06-a779-47c3-bdea-18933735e4cd_Artboard 25.png"
                },
                new Product
                {
                    Id = new Guid("b2350554-3af3-4cef-8ecf-36bfa03b51bf"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("05baa743-b4c3-450c-8b98-ae9b9e78df8c"),
                    Note = "BỘ SƯU TẬP \"SEEDY\"",
                    Name = "THIỆP “LÁ\"",
                    Description = "THIỆP “LÁ\"",
                    Price = 29000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/cb261d95-24e9-4ccf-9abf-34309e80dbf3_Artboard 27.png"
                },
                new Product
                {
                    Id = new Guid("d5f5a53c-2bad-420f-aa89-38ad16a09a09"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dba09-053a-4491-a770-210fb578375f"),
                    Note = "BỘ SƯU TẬP \"8/3\"",
                    Name = "THIỆP “YÊU-THƯƠNG\"",
                    Description = "THIỆP “YÊU-THƯƠNG\"",
                    Price = 25000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/4df4ada5-234e-42e0-bdad-4f3aed1857c2_yêu thương trước.png"
                },
                new Product
                {
                    Id = new Guid("07f7734f-d798-490f-8eef-4b2aba587549"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dba09-053a-4491-a770-210fb578375f"),
                    Note = "BỘ SƯU TẬP \"8/3\"",
                    Name = "THIỆP “CHỞ-CHE\"",
                    Description = "Thiệp Chở Che",
                    Price = 25000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/daa4afda-e1b3-4c7f-bea3-3f9a89bd05a6_chở che trước_1.png"
                },
                new Product
                {
                    Id = new Guid("3571d2b3-f6c2-44ae-bfbf-545a15ad7a87"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dba09-053a-4491-a770-210fb578375f"),
                    Note = "BỘ SƯU TẬP \"8/3\"",
                    Name = "THIỆP “THẦM-LẶNG\"",
                    Description = "Thiệp Thầm Lặng",
                    Price = 25000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/f45f3fee-140b-404c-ad42-9bc011605f45_thầm lặng trước_1.png"
                },
                new Product
                {
                    Id = new Guid("d02a195c-3bf2-4053-a285-65b0e6ca98cd"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("05baa743-b4c3-450c-8b98-ae9b9e78df8c"),
                    Note = "BỘ SƯU TẬP \"SEEDY\"",
                    Name = "THIỆP “MẦM\"",
                    Description = "THIỆP “MẦM\"",
                    Price = 29000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/d7b03ba1-7a15-432c-8dda-be2354b061d3_Artboard 23.png"
                },
                new Product
                {
                    Id = new Guid("1799b139-50cb-4902-8fbd-66930ecc1731"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("05baa743-b4c3-450c-8b98-ae9b9e78df8c"),
                    Note = "BỘ SƯU TẬP \"SEEDY\"",
                    Name = "THIỆP “HOA\"",
                    Description = "THIỆP “HOA\"",
                    Price = 29000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/662e6d9a-f541-47ad-bc50-21744a0a4261_Artboard 29.png"
                },
                new Product
                {
                    Id = new Guid("e2f69055-e491-432d-9877-8520e0ca0109"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "BỘ SƯU TẬP \"TẾT\"",
                    Name = "THIỆP “CHIẾU\"",
                    Description = "THIỆP “CHIẾU\"",
                    Price = 29000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/5a1c70dc-a009-408b-9ffb-6e11c2f1356a_chiếu card.png"
                },
                new Product
                {
                    Id = new Guid("ec5e79aa-b509-4f72-9075-8b4f23c86f21"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("6d92495e-b82d-44a0-8f56-4e9fe6f4a156"),
                    Note = "BỘ SƯU TẬP \"VIỆT PATTERN\"",
                    Name = "THIỆP “GẠCH\"",
                    Description = "THIỆP “GẠCH\"",
                    Price = 32000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/a28b909d-12d3-4450-a442-a222392e79d9_Artboard 10.png"
                },
                new Product
                {
                    Id = new Guid("21a71714-6ec9-4579-bcd3-9ba27fbba6fe"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dba09-053a-4491-a770-210fb578375f"),
                    Note = "BỘ SƯU TẬP \"8/3\"",
                    Name = "THIỆP “TẦN-TẢO\"",
                    Description = "THIỆP “TẦN-TẢO\"",
                    Price = 25000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/4120b43d-4ee3-4443-8a30-f3c3ee15b0ed_tần tảo trước_1.png"
                },
                new Product
                {
                    Id = new Guid("066ae684-4188-4baf-b85f-9f443fd9bb62"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("6d92495e-b82d-44a0-8f56-4e9fe6f4a156"),
                    Note = "BỘ SƯU TẬP \"VIỆT PATTERN\"",
                    Name = "THIỆP “GỐM\"",
                    Description = "THIỆP “GỐM\"",
                    Price = 32000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/88f895a2-a98f-4bc8-a630-654efbb89dc8_Artboard 8.png"
                },
                new Product
                {
                    Id = new Guid("8b5ae518-6461-4c6b-b986-ad3279faf659"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("20f929a6-8236-42aa-adfa-d532f817e1a2"),
                    Note = "BỘ SƯU TẬP \"VALENTINE\"",
                    Name = "THIỆP “CHỦ BÀI\" (NÂU)",
                    Description = "THIỆP “CHỦ BÀI\" (NÂU)",
                    Price = 25000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/238995e1-a939-44a5-b75d-ce77d7333dc1_nâu k chữ.png"
                },
                new Product
                {
                    Id = new Guid("25a9e67b-9be0-402c-98b2-b8042d93e481"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "BỘ SƯU TẬP \"TẾT\"",
                    Name = "THIỆP “UỐNG TRÀ\"",
                    Description = "THIỆP “UỐNG TRÀ\"",
                    Price = 29000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/6e567943-6b33-4565-9b09-14008bd7f08a_sưa ăn bánh.png"
                },
                new Product
                {
                    Id = new Guid("634b6cbb-d493-40aa-a367-c5cbc2fa78b9"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "BỘ SƯU TẬP \"TẾT\"",
                    Name = "THIỆP “BÀN ĂN\"",
                    Description = "THIỆP “BÀN ĂN\"",
                    Price = 29000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/a23f270f-cc8f-437b-8a59-b8e29b59e2c3_ sửa gà cúng có_.png"
                },
                new Product
                {
                    Id = new Guid("3f19972b-0733-419e-b399-da4460325c5c"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("6d92495e-b82d-44a0-8f56-4e9fe6f4a156"),
                    Note = "BỘ SƯU TẬP \"VIỆT PATTERN\"",
                    Name = "THIỆP “THỔ CẨM\"",
                    Description = "THIỆP “THỔ CẨM\"",
                    Price = 32000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/8ed961ee-6447-4f4d-a081-72d87b0eda30_Artboard 2.png"
                },
                new Product
                {
                    Id = new Guid("ebbfdcb4-c57d-4250-86dc-e0be0e74adbc"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    Note = "BỘ SƯU TẬP \"TẾT\"",
                    Name = "THIỆP “DỌN NHÀ\"",
                    Description = "THIỆP “DỌN NHÀ\"",
                    Price = 29000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/b14c2366-c8db-4286-a100-bd1f6df929a7_lau nhà.png"
                },
                new Product
                {
                    Id = new Guid("e5a1e140-5a9a-40f5-8b9f-f0430fe7192e"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("20f929a6-8236-42aa-adfa-d532f817e1a2"),
                    Note = "BỘ SƯU TẬP \"VALENTINE\"",
                    Name = "THIỆP “CHỦ BÀI\" (HỒNG)",
                    Description = "THIỆP “CHỦ BÀI\" (HỒNG)",
                    Price = 25000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/e1f08a7c-4a8d-44b3-b7a2-501c8682247d_hồng k chữ.png"
                },
                new Product
                {
                    Id = new Guid("8a1ecef0-3eca-40ae-8d4c-fb3ac8f0c53c"),
                    ProductCategoryId = new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                    OccasionId = new Guid("6d92495e-b82d-44a0-8f56-4e9fe6f4a156"),
                    Note = "BỘ SƯU TẬP \"VIỆT PATTERN\"",
                    Name = "THIỆP “CỬA\"",
                    Description = "THIỆP “CỬA\"",
                    Price = 32000.0m,
                    StockQuantity = 20,
                    ImageUrl = "Products/d3623b3f-2090-45ff-92cd-ec923d0ca2ec_mẫu 2 mặt trước.png"
                }
            );
        }
    }
}