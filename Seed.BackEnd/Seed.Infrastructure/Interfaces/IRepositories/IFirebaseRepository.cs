using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.DTOs.Firebase.AddImage;
namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IFirebaseRepository
    {
        Task<AddImageResponse> UploadImageAsync(AddImageRequest request);
        Task<GetImageResponse> GetImageAsync(GetImageRequest request);
    }
}
