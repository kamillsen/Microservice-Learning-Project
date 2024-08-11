using Core.Common.Concrete;
using Core.Models.Response;


namespace Bussiness.Abstract
{
    public interface IFlowerService


    {
        Task<ServiceResult<GetFlowerInformationResponseModel>> GetFlowerInformationsAsync();

    }
}
