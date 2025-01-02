using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class PointsHistory :BaseEntity
    {
        public Guid? UserID { get; set; }
        public string Email { get; set; }
        public int PointsChanged { get; set; }
        public string Reason { get; set; }
        public User User { get; set; }
    }
}
