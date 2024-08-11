using Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace flowers.Controllers
{

        [ApiController]
        [Route("[controller]")]
        public class FlowerController : ControllerBase
        {
            private readonly IFlowerService _flowerService;

           
            public FlowerController(IFlowerService flowerService)
            {
                _flowerService = flowerService;
            }

          

            [HttpGet("information")]
            public async Task<IActionResult> GetAsync()
            {
                var serviceResult = await _flowerService.GetFlowerInformationsAsync();
                return StatusCode((int)serviceResult.HttpStatusCode, serviceResult);
            }
        }
}
