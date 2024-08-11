using Core.Models.Response;
using Dapper;
using DataAccess.Queries;
using DataAccess.Repositories.Abstract;
using System.Data.SqlClient;

namespace DataAccess.Repositories.Concrete
{
    public class PlantRepository : IPlantRespository
    {
        public async Task<List<GetPlantInformationsResponseModel>> GetPlantInformationsAsync()
        {
            using var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=StajOkulu;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
            //using var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=StajOkulu;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
            var response = await connection.QueryAsync<GetPlantInformationsResponseModel>(
                sql: PlantQueries.GET_PLANT_INFORMATIONS,
                commandTimeout: 0);
            return response.ToList();
        }
    }
}
