using System.Collections.Generic;
using System.Linq;
using HexaMazeRetreat.Domain;
using SixLabors.ImageSharp;

namespace HexaMazeRetreat.Solution
{
    public class LevelSolver1
    {
        public Domain.Solution SolveLevel(MazeMap map)
        {
            var solution = new Domain.Solution();

            var startTile = map.Single(x => x.Kind == TileKind.Start);
            var finishTile = map.Single(x => x.Kind == TileKind.Finish);

            solution.Description = "Mijn automatische oplossing";
            solution.Steps = CalculateSteps(startTile, finishTile, map, new List<SolutionStep>());

            return solution;
        }

        private List<SolutionStep> CalculateSteps(MazeTile currentTile, MazeTile targetTile, MazeMap map, List<SolutionStep> steps)
        {
            if (currentTile == targetTile) return steps;

            for (int i = 0; i < 6; i++)
            {
                var newLocation = CalculateNewLocation((SolutionStep)i, currentTile.X, currentTile.Y);
                var targetKind = map[newLocation.X, newLocation.Y]?.Kind;

                if (targetKind is TileKind.Dirt or TileKind.Finish)
                {
                    steps.Add((SolutionStep)i);
                    return CalculateSteps(map[newLocation.X, newLocation.Y], targetTile, map, steps);
                }
            }

            return steps;
        }

        private Point CalculateNewLocation(SolutionStep step, int sourceX, int sourceY)
        {
            return step switch
            {
                SolutionStep.NorthEast => new Point(sourceY % 2 == 0 ? sourceX : sourceX + 1, sourceY - 1),
                SolutionStep.East => new Point(sourceX + 1, sourceY),
                SolutionStep.SouthEast => new Point(sourceY % 2 == 0 ? sourceX : sourceX + 1, sourceY + 1),
                SolutionStep.SouthWest => new Point(sourceX, sourceY + 1),
                SolutionStep.West => new Point(sourceX - 1, sourceY),
                SolutionStep.NorthWest => new Point(sourceX, sourceY - 1),
                _ => new Point(sourceX, sourceY)
            };
        }
    }
}