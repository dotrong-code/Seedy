using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid? UserID { get; set; }  // Nullable for guest orders
        public string ReceiverFullName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverEmail { get; set; }
        public int ReceiverWard { get; set; }
        public string WardName { get; set; }
        public int ReceiverDistrict { get; set; }
        public string DistrictName { get; set; }
        public int ReceiverProvince { get; set; }
        public string ProvinceName { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ShippingFee { get; set; }
        public string OrderService { get; set; }
        public string OrderNote { get; set; }
        public decimal MoneyCollection { get; set; }

        // Relationships
        public ICollection<OrderItem> OrderItems { get; set; }
        public User User { get; set; }
    }
}
