using System;
using HexaMazeRetreat.Blazor.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace HexaMazeRetreat.Blazor.Controllers
{
    [Route("_api/images")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly LevelBuilderHelper _levelBuilderHelper;
        private readonly IMemoryCache _memoryCache;

        public ImagesController(
            LevelBuilderHelper levelBuilderHelper,
            IMemoryCache memoryCache)
        {
            _levelBuilderHelper = levelBuilderHelper;
            _memoryCache = memoryCache;
        }

        [HttpGet, Route("{levelId}")]
        public async Task<IActionResult> GetImage(string levelId)
        {
            var levelImageBuffer = _memoryCache.Get<byte[]>(levelId);

            if (levelImageBuffer == null)
            {
                levelImageBuffer = await _levelBuilderHelper.BuildLevel(levelId);
                _memoryCache.Set(levelId, levelImageBuffer, TimeSpan.FromSeconds(10));
            }

            return File(levelImageBuffer, "image/jpg");
        }
    }
}