using HexaMazeRetreat.Blazor.DataAccess;
using HexaMazeRetreat.Blazor.Entities;
using HexaMazeRetreat.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using HexaMazeRetreat.Domain;

namespace HexaMazeRetreat.Blazor.Helpers
{
    public class PlaysHelper
    {
        private readonly HexaMazeRetreatDbContext _dbContext;

        public PlaysHelper(
            HexaMazeRetreatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetPlayersResponse> GetPlayers()
        {
            var playerNames = await _dbContext.Plays.Select(x => x.PlayerName)
                .Distinct().OrderBy(x => x).ToListAsync();

            var players = new GetPlayersResponse();

            for (int i = 0; i < playerNames.Count; i++)
            {
                players.Add(new Player { Index = i + 1, PlayerName = playerNames[i] });
            }

            return players;
        }

        public async Task<GetPlayersResponse> GetPlayersByLevel(string levelName)
        {
            var playerNames = await _dbContext.Plays.Where(
                x => x.LevelName == levelName).Select(x => x.PlayerName).Distinct().ToListAsync();

            var players = new GetPlayersResponse();

            for (int i = 0; i < playerNames.Count; i++)
            {
                players.Add(new Player { Index = i + 1, PlayerName = playerNames[i] });
            }

            return players;
        }

        public async Task<GetLastPlaysByLevelResponse> GetLastPlaysByLevel(string levelName)
        {
            var plays = await _dbContext.Plays.Where(
                x => x.LevelName == levelName).OrderByDescending(x => x.SubmittedOn).ToListAsync();

            var players = await GetPlayersByLevel(levelName);

            var playsByLevel = new GetLastPlaysByLevelResponse();

            foreach (var player in players)
            {
                var playsByPlayer = plays.Where(x => x.PlayerName == player.PlayerName).ToList();
                if (playsByPlayer.Count > 0)
                {
                    var lastPlay = playsByPlayer.First();

                    playsByLevel.Add(new PlayByPlayer
                    {
                        Index = player.Index,
                        PlayerName = player.PlayerName,
                        SubmittedSolution = new Solution
                        {
                            Description = lastPlay.Description,
                            Steps = JsonSerializer.Deserialize<List<SolutionStep>>(lastPlay.SubmittedSolution)
                        }
                    });
                }
            }

            return playsByLevel;
        }

        public async Task CreatePlay(CreatePlayRequest request, string levelName)
        {
            var play = new Play
            {
                Id = Guid.NewGuid(),
                PlayerName = request.PlayerName,
                LevelName = levelName,
                Description = request.SubmittedSolution.Description,
                SubmittedSolution = JsonSerializer.Serialize(request.SubmittedSolution.Steps),
                SubmittedOn = DateTime.UtcNow
            };

            await _dbContext.Plays.AddAsync(play);
            await _dbContext.SaveChangesAsync();
        }
    }
}