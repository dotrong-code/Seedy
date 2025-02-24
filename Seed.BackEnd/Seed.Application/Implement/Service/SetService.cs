using Seed.Application.Common.Result;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.Common;

namespace Seed.Application.Implement.Service
{
    public class SetService : ISetService
    {
        private readonly UnitOfWork _unitOfWork;
        public SetService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result> GetSetDetail(Guid id)
        {
            var detail = await _unitOfWork.SetRepository.GetSetDetail(id);
            if (detail == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotFound());
            }
            return Result.SuccessWithObject(detail);
        }

        public async Task<Result> GetListSet()
        {
            var list = await _unitOfWork.SetRepository.GetListSet();
            return Result.SuccessWithObject(list);
        }
    }
}
