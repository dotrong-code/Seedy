﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.User.Get
{
    public class GetRespone
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string? Avatar { get; set; }
    }
}
