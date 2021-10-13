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

        [HttpPost("{levelName}")]
        public async Task<IActionResult> CreatePlay(CreatePlayRequest request, string levelName)
        {
            await _playsHelper.CreatePlay(request, levelName);
            return Created("", request);
        }
    }
}