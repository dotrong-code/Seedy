﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.ProductCategory.Create
{
    public class AddProductCategoryResponse
    {
        public Guid ProductCategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
