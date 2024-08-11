using Bussiness.Abstract;
using Core.Common.Concrete;
using Core.Constants;
using Core.Models.Response;
using DataAccess.Repositories.Abstract;
using System.Net;


namespace Business.Concrete
{
    public class FlowerService : IFlowerService
    {
        private readonly IFlowerRepository _FlowerRepository;

        public FlowerService(IFlowerRepository FlowerRepository)
        {
            _FlowerRepository = FlowerRepository;
        }

        public async Task<ServiceResult<GetFlowerInformationResponseModel>> GetFlowerInformationsAsync()
        {
            try
            {
                var response = await _FlowerRepository.GetFlowerInformationsAsync();

                if (response == null)
                {
                    return new ServiceResult<GetFlowerInformationResponseModel>
                    {
                        HttpStatusCode = HttpStatusCode.NoContent
                    };
                }
                else
                {
                    return new ServiceResult<GetFlowerInformationResponseModel>
                    {
                        HttpStatusCode = HttpStatusCode.OK,
                        UserMessage = ResponseMessagesConstant.SUCCESS,
                        InternalMessage = ResponseMessagesConstant.SUCCESS,
                        Data = response
                    };
                }
            }
            catch (Exception exception)
            {
                return new ServiceResult<GetFlowerInformationResponseModel>
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    UserMessage = ResponseMessagesConstant.EXCEPTION,
                    InternalMessage = $"{exception.Message} {exception.InnerException}",
                };
            }
        }
    }
}
