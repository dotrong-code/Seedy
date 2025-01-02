using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class UserEmail : BaseEntity
    {
        [Key, Column(Order = 0)]
        [ForeignKey("UserID")]
        public Guid UserID { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("EmailTemplateId")]
        public Guid EmailTemplateId { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public EmailTemplate EmailTemplate { get; set; }
    }
}
