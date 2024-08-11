using Core.Models.Response;
using Dapper;
using DataAccess.Queries;
using DataAccess.Repositories.Abstract;
using System.Data.SqlClient;

namespace DataAccess.Repositories.Concrete
{
    public class FlowerRepository : IFlowerRepository
    {
        public async Task<List<GetFlowerInformationResponseModel>> GetFlowerInformationsAsync()
        {
            
           
                using var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Flowers;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
                var response = await connection.QueryAsync<GetFlowerInformationResponseModel>(
                    sql: FlowerQueries.GET_FLOWER_INFORMATIONS,
                    commandTimeout: 0);
                return response.ToList();
            
           

        }
    }
}
