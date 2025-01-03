using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.Common;
using Seed.Application.DTOs.Firebase.AddImage;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Application.Implement.Service
{
    public class FirebaseService : IFirebaseService
    {
        private readonly IFirebaseRepository _firebaseRepository;

        public FirebaseService(IFirebaseRepository firebaseRepository)
        {
            _firebaseRepository = firebaseRepository;
        }

        public async Task<Result> UploadImageAsync(IFormFile file, string folder)
        {
            // Create the request DTO
            var request = new AddImageRequest(file, folder);

            // Call the repository method
            var response = await _firebaseRepository.UploadImageAsync(request);

            // Check if the repository returned success
            if (response.Success)
            {
                // Return success result with file path
                return Result.SuccessWithObject(response.FilePath);
            }
            else
            {
                // Return failure result with error message
                return Result.Failure(response.Error);
            }
        }

        public async Task<Result> GetImageAsync(GetImageRequest request)
        {
            try
            {
                var imageStream = await _firebaseRepository.GetImageAsync(request);
                return Result.SuccessWithObject(imageStream);
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("GetImageFailed", ex.Message));
            }
        }


    }
}
