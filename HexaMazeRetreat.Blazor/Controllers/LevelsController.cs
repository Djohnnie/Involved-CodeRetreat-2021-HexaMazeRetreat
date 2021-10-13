using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HexaMazeRetreat.Blazor.Helpers;

namespace HexaMazeRetreat.Blazor.Controllers
{
    [Route("_api/levels")]
    [ApiController]
    public class LevelsController : ControllerBase
    {
        private readonly LevelsHelper _levelsHelper;

        public LevelsController(
            LevelsHelper levelsHelper)
        {
            _levelsHelper = levelsHelper;
        }

        [HttpGet("{levelName}")]
        public async Task<IActionResult> GetLevelByName(string levelName)
        {
            var level = await _levelsHelper.GetLevelByName(levelName);
            return Ok(level);
        }
    }
}