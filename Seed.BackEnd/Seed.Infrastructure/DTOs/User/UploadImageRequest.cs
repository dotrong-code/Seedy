using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Seed.Infrastructure.DTOs.User
{
    public class UploadImageRequest
    {
        public IFormFile ImageFile { get; set; }
        public Guid Id { get; set; }

    }
}
