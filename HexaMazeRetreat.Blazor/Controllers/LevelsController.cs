using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HexaMazeRetreat.Blazor.Helpers;
using HexaMazeRetreat.Blazor.Validators;

namespace HexaMazeRetreat.Blazor.Controllers
{
    [Route("_api/levels")]
    [ApiController]
    public class LevelsController : ControllerBase
    {
        private readonly LevelsHelper _levelsHelper;
        private readonly LevelsValidator _levelsValidator;

        public LevelsController(
            LevelsHelper levelsHelper,
            LevelsValidator levelsValidator)
        {
            _levelsHelper = levelsHelper;
            _levelsValidator = levelsValidator;
        }

        [HttpGet("{levelName}")]
        public async Task<IActionResult> GetLevelByName(string levelName)
        {
            if (!_levelsValidator.IsLevelValid(levelName))
            {
                return NotFound();
            }

            var level = await _levelsHelper.GetLevelByName(levelName);
            return Ok(level);
        }
    }
}