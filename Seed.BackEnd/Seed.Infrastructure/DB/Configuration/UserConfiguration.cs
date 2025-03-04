using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = new Guid("85966b29-9f9f-49c6-b366-420245696c2f"),
                    FullName = "Admin",
                    Email = "admin@gmail.com",
                    PhoneNumber = "0254725644",
                    Address = "Admin",
                    PasswordHash = "String123!",
                    ProfilePictureUrl = "Default",
                    DateOfBirth = DateTime.Now,
                    IsEmailConfirmed = true,
                    IsRegister = true,
                    Points = 0,
                    Role = 1,

                },
                new User
                {
                    Id = new Guid("bfa4ee73-f13b-487c-8fd4-0e074725d2dd"),
                    FullName = "User_1",
                    Email = "quocthangjk@gmail.com",
                    PhoneNumber = "0914725688",
                    Address = "Userrr",
                    PasswordHash = "String123!",
                    ProfilePictureUrl = "Default",
                    DateOfBirth = DateTime.Now,
                    IsEmailConfirmed = true,
                    Points = 0,
                    IsRegister = true,
                    Role = 3,

                },
                new User
                {
                    Id = new Guid("04bc7428-8f38-466e-864d-3518a70be851"),
                    Email = "pqt2802@gmail.com",
                    PhoneNumber = "0914725688",
                    Points = 0,
                    IsRegister = false,
                    Role = 3
                }

                );
        }
    }
}
