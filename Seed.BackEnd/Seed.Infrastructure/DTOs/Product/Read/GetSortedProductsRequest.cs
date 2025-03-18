using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.Product.Read
{
    public class GetSortedProductsRequest
    {
        public Guid? OccasionId { get; set; } // Optional: Lọc theo OccasionId
        public int MaxProducts { get; set; } = 10; // Số lượng tối đa sản phẩm trả về, mặc định là 10
    }
}
