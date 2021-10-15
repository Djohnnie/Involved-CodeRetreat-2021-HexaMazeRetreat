using System;
using System.Threading.Tasks;
using HexaMazeRetreat.Domain.Contracts;
using static System.Console;

namespace HexaMazeRetreat.Solution
{
    class Program
    {
        private static readonly ApiClient _apiClient = new ApiClient();
        private static readonly LevelSolver _levelSolver = new LevelSolver();

        static async Task Main(string[] args)
        {
            WriteLine("HexaMazeRetreat solver");
            WriteLine("----------------------");
            WriteLine();
            Write("Kies een level: ");

            var levelName = ReadLine();

            var level = await _apiClient.GetLevelByName(levelName);

            var solution = _levelSolver.SolveLevel(level.Map);

            await _apiClient.CreatePlay(new CreatePlayRequest
            {
                PlayerName = "DJOHNNIE",
                SubmittedSolution = solution
            }, levelName);
        }
    }
}