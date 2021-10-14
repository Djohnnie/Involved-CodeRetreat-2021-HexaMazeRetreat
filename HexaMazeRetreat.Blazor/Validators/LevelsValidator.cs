using HexaMazeRetreat.Blazor.Helpers;

namespace HexaMazeRetreat.Blazor.Validators
{
    public class LevelsValidator
    {
        public bool IsLevelValid(string levelName)
        {
            var levelResourceName = BuildLevelResourceName(levelName);
            var levelJson = EmbeddedResourceHelper.GetLevelByResourceName(levelResourceName);

            return !string.IsNullOrEmpty(levelJson);
        }

        private string BuildLevelResourceName(string levelName)
        {
            return $"HexaMazeRetreat.Blazor.Levels.{levelName}.hexajson";
        }
    }
}