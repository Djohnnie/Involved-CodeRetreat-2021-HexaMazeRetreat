using System.Collections.Generic;
using HexaMazeRetreat.Blazor.DataAccess;
using HexaMazeRetreat.Domain;
using HexaMazeRetreat.Domain.Contracts;
using System.Text.Json;
using System.Threading.Tasks;

namespace HexaMazeRetreat.Blazor.Helpers
{
    public class LevelsHelper
    {
        private readonly HexaMazeRetreatDbContext _dbContext;

        public LevelsHelper(
            HexaMazeRetreatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<GetLevelByNameResponse> GetLevelByName(string levelName)
        {
            var levelResourceName = BuildLevelResourceName(levelName);
            var levelJson = EmbeddedResourceHelper.GetLevelByResourceName(levelResourceName);
            var level = JsonSerializer.Deserialize<MazeMap>(levelJson);
            level.RemoveAll(x => !x.IsUsed);

            return Task.FromResult(new GetLevelByNameResponse
            {
                LevelName = levelName,
                Map = level
            });
        }

        private string BuildLevelResourceName(string levelName)
        {
            return $"HexaMazeRetreat.Blazor.Levels.{levelName}.hexajson";
        }
    }
}