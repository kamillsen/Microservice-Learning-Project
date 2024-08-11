using Core.Models.Response;

namespace DataAccess.Repositories.Abstract
{
    public interface IFlowerRepository
    {
        Task<List<GetFlowerInformationResponseModel>> GetFlowerInformationsAsync();
    }
}
