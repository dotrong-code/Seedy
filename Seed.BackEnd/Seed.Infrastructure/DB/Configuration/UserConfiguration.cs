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
