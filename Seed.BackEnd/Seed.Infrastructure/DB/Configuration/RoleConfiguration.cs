using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    RoleId = 1,
                    RoleName = "Admin"
                },
                new Role
                {
                    RoleId = 2,
                    RoleName = "Staff"
                },
                new Role
                {
                    RoleId = 3,
                    RoleName = "Customer"
                }

                );
        }
    }
}
