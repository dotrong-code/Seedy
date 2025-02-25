using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.ViettelPost
{
    public class ViettelLoginResponse
    {
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public ViettelPostUserData Data { get; set; }
    }

    public class ViettelPostUserData
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public int Partner { get; set; }
        public string Phone { get; set; }
    }
}
