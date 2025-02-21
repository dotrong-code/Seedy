namespace Seed.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public int? Points { get; set; } = 0;
        //for guess
        public bool? IsRegister { get; set; }
        public int? Role { get; set; }//1 admin, 2 staff, 3 customer

        // Relationships
        public ICollection<Order>? Orders { get; set; } // Nullable relationship
        public ICollection<Cart>? Carts { get; set; } // Nullable relationship
        public ICollection<PointsHistory>? PointsHistories { get; set; }
        public ICollection<Payment>? Payments { get; set; }
        public ICollection<UserEmail>? UserEmails { get; set; }
    }
}
