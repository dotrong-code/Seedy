using Seed.Application.Common.Result;

namespace Seed.Application.Interface.IService
{
    public interface ISetService
    {
        public Task<Result> GetListSet();
        public Task<Result> GetSetDetail(Guid id);
    }
}
