using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.Order
{
    public class CreateOrderRequest
    {
        public Guid? UserID { get; set; }
        public string ReceiverFullName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverEmail { get; set; }
        public int ReceiverWard { get; set; }
        public int ReceiverDistrict { get; set; }
        public int ReceiverProvince { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ShippingFee { get; set; }
        public string OrderService { get; set; }
        public string OrderNote { get; set; }
        public decimal MoneyCollection { get; set; }
        public List<OrderItemRequest> OrderItems { get; set; }
    }

    public class OrderItemRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
