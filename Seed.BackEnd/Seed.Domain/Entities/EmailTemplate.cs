using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    [Table("EmailTemplate")]
    public class EmailTemplate
    {
        public Guid EmailTemplateId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Type { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string ImageMappingsJson { get; set; } = "{}";
        public ICollection<UserEmail> UserEmails { get; set; }

    }
}
