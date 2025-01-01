using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class Message
    {
        public Guid Id { get; set; }  // ID của tin nhắn
        public Guid SenderId { get; set; }  // ID của customer
        public Guid RecipientId { get; set; }  // ID của veterinarian
        public string Content { get; set; }  // Nội dung tin nhắn
        public DateTime Timestamp { get; set; }  // Thời gian gửi tin nhắn
    }
}
