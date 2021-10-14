using System;
using HexaMazeRetreat.Blazor.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HexaMazeRetreat.Blazor.Validators;
using Microsoft.Extensions.Caching.Memory;

namespace HexaMazeRetreat.Blazor.Controllers
{
    [Route("_api/images")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly LevelBuilderHelper _levelBuilderHelper;
        private readonly LevelsValidator _levelsValidator;
        private readonly IMemoryCache _memoryCache;

        public ImagesController(
            LevelBuilderHelper levelBuilderHelper,
            LevelsValidator levelsValidator,
            IMemoryCache memoryCache)
        {
            _levelBuilderHelper = levelBuilderHelper;
            _levelsValidator = levelsValidator;
            _memoryCache = memoryCache;
        }

        [HttpGet, Route("{levelName}")]
        public async Task<IActionResult> GetImage(string levelName)
        {
            if (!_levelsValidator.IsLevelValid(levelName))
            {
                return NotFound();
            }

            var levelImageBuffer = _memoryCache.Get<byte[]>(levelName);

            if (levelImageBuffer == null)
            {
                levelImageBuffer = await _levelBuilderHelper.BuildLevel(levelName);
                _memoryCache.Set(levelName, levelImageBuffer, TimeSpan.FromSeconds(10));
            }

            return File(levelImageBuffer, "image/jpg");
        }
    }
}