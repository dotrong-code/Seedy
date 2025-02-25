using System.Collections.Generic;

namespace Seed.Infrastructure.DTOs.ViettelPost
{
    public class ViettelWardResponse
    {
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public List<WardData> Data { get; set; }
    }

    public class WardData
    {
        public int WARDS_ID { get; set; }
        public string WARDS_NAME { get; set; }
        public int DISTRICT_ID { get; set; }
    }
}
