using HexaMazeRetreat.Domain;
using SixLabors.ImageSharp;
using System.Collections.Generic;
using System.Linq;

namespace HexaMazeRetreat.Solution
{
    public class LevelSolver2
    {
        public Domain.Solution SolveLevel(MazeMap map)
        {
            var solution = new Domain.Solution();

            // Search start and finish
            var startTile = map.Single(x => x.Kind == TileKind.Start);
            var finishTile = map.Single(x => x.Kind == TileKind.Finish);

            // Walk all paths
            var allPossiblePaths = CalculateAllPossiblePaths(map, startTile, finishTile);

            // Backtrack for solution
            var solutionSteps = BackTrackForSolution(map, allPossiblePaths, startTile, finishTile);
            solutionSteps.Reverse();

            for (int i = 0; i < solutionSteps.Count; i++)
            {
                solutionSteps[i] = solutionSteps[i] switch
                {
                    SolutionStep.NorthEast => SolutionStep.SouthWest,
                    SolutionStep.East => SolutionStep.West,
                    SolutionStep.SouthEast => SolutionStep.NorthWest,
                    SolutionStep.SouthWest => SolutionStep.NorthEast,
                    SolutionStep.West => SolutionStep.East,
                    SolutionStep.NorthWest => SolutionStep.SouthEast
                };
            }
            foreach (var step in solutionSteps)
            {
                
            }

            solution.Description = "Mijn automatische oplossing";
            solution.Steps = solutionSteps;

            return solution;
        }

        private Dictionary<MazeTile, int> CalculateAllPossiblePaths(MazeMap map, MazeTile startTile, MazeTile finishTile)
        {
            var allPossiblePaths = new Dictionary<MazeTile, int>();

            var currentStepNumber = 0;

            var possibleTargets = new List<MazeTile>();
            allPossiblePaths.Add(startTile, currentStepNumber);
            possibleTargets.Add(startTile);

            while (!possibleTargets.Contains(finishTile))
            {
                currentStepNumber++;
                var newPossibleTargets = new List<MazeTile>();

                foreach (var currentTile in possibleTargets)
                {
                    for (int direction = 0; direction < 6; direction++)
                    {
                        var newLocation = CalculateNewLocation((SolutionStep)direction, currentTile.X, currentTile.Y);
                        var targetTile = map[newLocation.X, newLocation.Y];

                        if (targetTile != null)
                        {
                            if (!allPossiblePaths.ContainsKey(targetTile) && targetTile.Kind is TileKind.Dirt or TileKind.Finish)
                            {
                                newPossibleTargets.Add(targetTile);
                                allPossiblePaths.Add(targetTile, currentStepNumber);
                            }
                        }
                    }
                }

                possibleTargets = newPossibleTargets;
            }

            return allPossiblePaths;
        }

        private List<SolutionStep> BackTrackForSolution(MazeMap map, Dictionary<MazeTile, int> allPossiblePaths, MazeTile startTile, MazeTile finishTile)
        {
            var steps = new List<SolutionStep>();
            var finishStepNumber = allPossiblePaths[finishTile];
            var currentStepNumber = finishStepNumber - 1;

            var currentTile = finishTile;

            while (currentStepNumber >= 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    var newLocation = CalculateNewLocation((SolutionStep)i, currentTile.X, currentTile.Y);
                    var targetTile = map[newLocation.X, newLocation.Y];

                    if (targetTile != null && allPossiblePaths.ContainsKey(targetTile) && allPossiblePaths[targetTile] == currentStepNumber)
                    {
                        steps.Add((SolutionStep)i);
                        currentTile = targetTile;
                        break;
                    }
                }

                currentStepNumber--;
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
                SolutionStep.SouthWest => new Point(sourceY % 2 == 0 ? sourceX - 1 : sourceX, sourceY + 1),
                SolutionStep.West => new Point(sourceX - 1, sourceY),
                SolutionStep.NorthWest => new Point(sourceY % 2 == 0 ? sourceX - 1 : sourceX, sourceY - 1),
                _ => new Point(sourceX, sourceY)
            };
        }
    }
}