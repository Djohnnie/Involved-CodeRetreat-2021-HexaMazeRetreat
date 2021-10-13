using System.Threading.Tasks;
using HexaMazeRetreat.Blazor.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace HexaMazeRetreat.Blazor.Controllers
{
    [Route("_api/players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly PlaysHelper _playsHelper;

        public PlayersController(
            PlaysHelper playsHelper)
        {
            _playsHelper = playsHelper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _playsHelper.GetPlayers();
            return Ok(players);
        }
    }
}