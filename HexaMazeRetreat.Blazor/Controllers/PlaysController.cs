using HexaMazeRetreat.Blazor.Helpers;
using HexaMazeRetreat.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HexaMazeRetreat.Blazor.Controllers
{
    [Route("_api/plays")]
    [ApiController]
    public class PlaysController : ControllerBase
    {
        private readonly PlaysHelper _playsHelper;

        public PlaysController(
            PlaysHelper playsHelper)
        {
            _playsHelper = playsHelper;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetPlays()
        //{
        //    await _dbContext.Database.MigrateAsync();
        //    var plays = await _dbContext.Plays.ToListAsync();
        //    return Ok(plays);
        //}

        [HttpPost]
        public async Task<IActionResult> CreatePlay(CreatePlayRequest request)
        {
            await _playsHelper.CreatePlay(request);
            return Created("", request);
        }
    }
}