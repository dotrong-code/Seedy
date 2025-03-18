using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasData(
                new ProductImage
                {
                    Id = new Guid("550e8400-e29b-41d4-a716-323c53e2440e"),
                    ProductId = new Guid("d0aea562-6c4b-4d0c-baa7-323c53e2440e"),
                    ImageUrl = "Products/35a5fb45-b0a3-4ac6-8fa1-32ff24439b94_Artboard 26.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                    ProductId = new Guid("b2350554-3af3-4cef-8ecf-36bfa03b51bf"),
                    ImageUrl = "Products/ec4fb698-fc32-4a56-888d-7a1a9065ecf5_Artboard 28.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("a1b2c3d4-e5f6-4a7b-8c9d-0f1e2d3c4b5a"),
                    ProductId = new Guid("d5f5a53c-2bad-420f-aa89-38ad16a09a09"),
                    ImageUrl = "Products/bc7740b8-c23a-47cf-9174-90d154ac2e3f_yêu thương sau_1.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("b9d8e7f0-1234-5678-9abc-def012345678"),
                    ProductId = new Guid("07f7734f-d798-490f-8eef-4b2aba587549"),
                    ImageUrl = "Products/e85ee9ef-1cca-4036-9620-c6c8564874d8_chở che sau_1.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("c4d3e2f1-9a8b-4c6d-7e5f-0a1b2c3d4e5f"),
                    ProductId = new Guid("3571d2b3-f6c2-44ae-bfbf-545a15ad7a87"),
                    ImageUrl = "Products/aeb23ec9-f5c3-4b9a-a35c-da81939f3c9c_thầm lặng sau_1.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("d7e6f5a0-2b3c-4d1e-8f9a-0b1c2d3e4f5a"),
                    ProductId = new Guid("d02a195c-3bf2-4053-a285-65b0e6ca98cd"),
                    ImageUrl = "Products/14b7653e-076b-41d2-a769-424824263671_Artboard 24.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("e9f8a7b6-3c2d-4e1f-9b0a-1c2d3e4f5a6b"),
                    ProductId = new Guid("1799b139-50cb-4902-8fbd-66930ecc1731"),
                    ImageUrl = "Products/07591f17-aab2-4815-ba95-cbcd3ce306b8_Artboard 30.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("f0b1c2d3-4e5f-6a7b-8c9d-0e1f2a3b4c5d"),
                    ProductId = new Guid("e2f69055-e491-432d-9877-8520e0ca0109"),
                    ImageUrl = "Products/8c684f0b-fc3c-4044-bca7-f01efb13c4c1_sau 3.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("a2b3c4d5-6e7f-8a9b-0c1d-2e3f4a5b6c7d"),
                    ProductId = new Guid("ec5e79aa-b509-4f72-9075-8b4f23c86f21"),
                    ImageUrl = "Products/91afe37b-5cd7-4df4-8371-44a48b8f783a_Artboard 11.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("b4c5d6e7-8f9a-0b1c-2d3e-4f5a6b7c8d9e"),
                    ProductId = new Guid("21a71714-6ec9-4579-bcd3-9ba27fbba6fe"),
                    ImageUrl = "Products/83964db1-a01a-425f-834c-44c1e795f1f5_tần tảo sau_1.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("c6d7e8f9-0a1b-2c3d-4e5f-6a7b8c9d0e1f"),
                    ProductId = new Guid("066ae684-4188-4baf-b85f-9f443fd9bb62"),
                    ImageUrl = "Products/a3004b4e-9d7f-41e3-8964-7f623e964f0f_Artboard 9.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("d8e9f0a1-2b3c-4d5e-6f7a-8b9c0d1e2f3a"),
                    ProductId = new Guid("8b5ae518-6461-4c6b-b986-ad3279faf659"),
                    ImageUrl = "Products/60a3267b-9e5e-45dd-b4a9-b00075b5e4a1_mặt sau nâu.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("e0f1a2b3-4c5d-6e7f-8a9b-0c1d2e3f4a5b"),
                    ProductId = new Guid("25a9e67b-9be0-402c-98b2-b8042d93e481"),
                    ImageUrl = "Products/f4872771-ed5c-4991-a373-a6b03c2aad74_sau 4.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("f2a3b4c5-6d7e-8f9a-0b1c-2d3e4f5a6b7c"),
                    ProductId = new Guid("634b6cbb-d493-40aa-a367-c5cbc2fa78b9"),
                    ImageUrl = "Products/7069fe84-4a1b-4b92-a444-2330328dd24e_sau 1.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("a4b5c6d7-8e9f-0a1b-2c3d-4e5f6a7b8c9d"),
                    ProductId = new Guid("3f19972b-0733-419e-b399-da4460325c5c"),
                    ImageUrl = "Products/8566252f-0e12-4d74-bcf2-8137f1488b02_Artboard 3.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("b6c7d8e9-0f1a-2b3c-4d5e-6f7a8b9c0d1e"),
                    ProductId = new Guid("ebbfdcb4-c57d-4250-86dc-e0be0e74adbc"),
                    ImageUrl = "Products/a3f74131-88f7-4775-991e-c87aa6f1836d_mặt sau dọn lòng.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("c8d9e0f1-2a3b-4c5d-6e7f-8a9b0c1d2e3f"),
                    ProductId = new Guid("e5a1e140-5a9a-40f5-8b9f-f0430fe7192e"),
                    ImageUrl = "Products/96d4f760-afc2-4ce2-a2bd-3d2c4ea71f2d_mặt sau hồng.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                },
                new ProductImage
                {
                    Id = new Guid("d0e1f2a3-4b5c-6d7e-8f9a-0b1c2d3e4f5a"),
                    ProductId = new Guid("8a1ecef0-3eca-40ae-8d4c-fb3ac8f0c53c"),
                    ImageUrl = "Products/74575966-fa81-4ad0-9da9-b416401f38a2_mẫu 2 mặt sau.png",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    IsDeleted = false
                }
            );
        }
    }
}