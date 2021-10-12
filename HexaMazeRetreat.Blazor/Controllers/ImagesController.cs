using HexaMazeRetreat.Blazor.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HexaMazeRetreat.Blazor.Controllers
{
    [Route("_api/images")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly LevelBuilderHelper _levelBuilderHelper;

        public ImagesController(
            LevelBuilderHelper levelBuilderHelper)
        {
            _levelBuilderHelper = levelBuilderHelper;
        }

        [HttpGet, Route("{levelId}")]
        public async Task<IActionResult> GetImage(string levelId)
        {
            var levelImageBuffer = await _levelBuilderHelper.BuildLevel(levelId);
            return File(levelImageBuffer, "image/png");
        }
    }
}