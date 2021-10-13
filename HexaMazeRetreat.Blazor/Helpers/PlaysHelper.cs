using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using HexaMazeRetreat.Blazor.DataAccess;
using HexaMazeRetreat.Domain.Contracts;
using System.Threading.Tasks;
using HexaMazeRetreat.Blazor.Entities;
using Microsoft.EntityFrameworkCore;

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
            var playerNames = await _dbContext.Plays.Select(x => x.PlayerName).Distinct().ToListAsync();

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

        public async Task CreatePlay(CreatePlayRequest request)
        {
            var play = new Play
            {
                Id = Guid.NewGuid(),
                PlayerName = request.PlayerName,
                Description = request.SubmittedSolution.Description,
                SubmittedSolution = JsonSerializer.Serialize(request.SubmittedSolution.Steps),
                SubmittedOn = DateTime.UtcNow
            };

            await _dbContext.Plays.AddAsync(play);
            await _dbContext.SaveChangesAsync();
        }
    }
}