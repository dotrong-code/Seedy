namespace Seed.Domain.Entities
{
    public class Occasion : BaseEntity
    {
        public string OccasionName { get; set; }
        public string Description { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Set>? Sets { get; set; }
    }
}
