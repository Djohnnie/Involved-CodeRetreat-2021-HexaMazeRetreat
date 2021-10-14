using HexaMazeRetreat.Blazor.Helpers;
using HexaMazeRetreat.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HexaMazeRetreat.Blazor.Validators;

namespace HexaMazeRetreat.Blazor.Controllers
{
    [Route("_api/plays")]
    [ApiController]
    public class PlaysController : ControllerBase
    {
        private readonly PlaysHelper _playsHelper;
        private readonly LevelsValidator _levelsValidator;

        public PlaysController(
            PlaysHelper playsHelper,
            LevelsValidator levelsValidator)
        {
            _playsHelper = playsHelper;
            _levelsValidator = levelsValidator;
        }

        [HttpPost("{levelName}")]
        public async Task<IActionResult> CreatePlay(CreatePlayRequest request, string levelName)
        {
            if (!_levelsValidator.IsLevelValid(levelName))
            {
                return NotFound();
            }

            if (request == null)
            {
                return BadRequest("Invalid request body!");
            }

            if (string.IsNullOrWhiteSpace(request.PlayerName))
            {
                return BadRequest("PlayerName is required!");
            }

            if (request.SubmittedSolution == null)
            {
                return BadRequest("Invalid SubmittedSolution!");
            }

            if (string.IsNullOrWhiteSpace(request.SubmittedSolution.Description))
            {
                return BadRequest("SubmittedSolution Description is required!");
            }

            if (request.SubmittedSolution.Steps == null)
            {
                return BadRequest("Invalid SubmittedSolution Steps!");
            }

            if (request.SubmittedSolution.Steps.Count == 0)
            {
                return BadRequest("At least one SubmittedSolution step is required!");
            }

            await _playsHelper.CreatePlay(request, levelName);
            return Created("", request);
        }
    }
}