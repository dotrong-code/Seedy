using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.Order
{
    public class UserOrderResponse
    {
        public Guid OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedDate { get; set; } // Giả sử BaseEntity có thuộc tính này
        public string OrderNote { get; set; }
        public decimal ShippingFee { get; set; }
        public string OrderService { get; set; }
    }

    public class OrderDetailResponse
    {
        public Guid OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public string OrderNote { get; set; }
        public decimal ShippingFee { get; set; }
        public string OrderService { get; set; }
        public List<OrderItemDetailResponse> Items { get; set; }
    }

    public class OrderItemDetailResponse
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
