using Core.Models.Response;

namespace DataAccess.Repositories.Abstract
{
    public interface IPlantRespository
    {
        Task<List<GetPlantInformationsResponseModel>> GetPlantInformationsAsync();
    }
}
