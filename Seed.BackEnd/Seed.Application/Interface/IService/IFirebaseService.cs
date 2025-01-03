using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Seed.Application.Common.Result;

namespace Seed.Application.Interface.IService
{
    public interface IFirebaseService
    {
        Task<Result> UploadImageAsync(IFormFile file, string folder);
        Task<Result> GetImageAsync(GetImageRequest request);
    }
}
