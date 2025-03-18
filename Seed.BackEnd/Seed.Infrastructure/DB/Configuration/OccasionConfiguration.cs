using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class OccasionConfiguration : IEntityTypeConfiguration<Occasion>
    {
        public void Configure(EntityTypeBuilder<Occasion> builder)
        {
            builder.HasData(
                new Occasion
                {
                    Id = new Guid("3c051805-0729-4b08-a47e-0bc5eaf4eeee"),
                    OccasionName = "Spring",
                    Description = "Description"
                },
                new Occasion
                {
                    Id = new Guid("a7619a43-a697-45b2-814c-fd8fbfdfea44"),
                    OccasionName = "Summer",
                    Description = "Description"
                },
                new Occasion
                {
                    Id = new Guid("97595211-a421-4a99-9840-5e795a2b3eef"),
                    OccasionName = "Autumn",
                    Description = "Description"
                },
                new Occasion
                {
                    Id = new Guid("7698f44c-4710-4e9a-98c0-8e6f80cc9d4d"),
                    OccasionName = "Winter",
                    Description = "Description"
                },
                new Occasion
                {
                    Id = new Guid("20f929a6-8236-42aa-adfa-d532f817e1a2"),
                    OccasionName = "Valentine",
                    Description = "Description"
                },
                new Occasion
                {
                    Id = new Guid("479dba09-053a-4491-a770-210fb578375f"),
                    OccasionName = "8-3",
                    Description = "Description"
                },
                new Occasion
                {
                    Id = new Guid("479dca09-053b-4491-a880-210fb578375a"),
                    OccasionName = "TẾT",
                    Description = "Description"
                },
                new Occasion
                {
                    Id = new Guid("05baa743-b4c3-450c-8b98-ae9b9e78df8c"),
                    OccasionName = "SEEDY BÌNH THƯỜNG",
                    Description = "Description"
                },
                new Occasion
                {
                    Id = new Guid("6d92495e-b82d-44a0-8f56-4e9fe6f4a156"),
                    OccasionName = "VIỆT PATTERN",
                    Description = "Description"
                }

                );
        }
    }
}
