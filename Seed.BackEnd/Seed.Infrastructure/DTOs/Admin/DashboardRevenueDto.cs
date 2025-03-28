namespace Seed.Infrastructure.DTOs.Admin
{
    public class DashboardRevenueDto
    {
        public List<RevenueOverTimeDto> RevenueOverTime { get; set; }
        public List<SalesCategoryDto> SalesByCategory { get; set; }
        public List<TopSellingCardDto> TopSellingCards { get; set; }
    }

    public class RevenueOverTimeDto
    {
        public DateTime Date { get; set; }
        public decimal Revenue { get; set; }
        public int TotalPayment { get; set; }

    }

    public class SalesCategoryDto
    {
        public string Category { get; set; }
        public decimal Revenue { get; set; }
    }
    public class TopSellingCardDto
    {
        public string CardName { get; set; }
        public decimal Revenue { get; set; }
    }
}
