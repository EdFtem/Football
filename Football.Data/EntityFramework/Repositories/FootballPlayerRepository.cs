using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football.Core.Data;
using Football.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Football.Data.EntityFramework.Repositories
{
    public class FootballPlayerRepository : IFootballPlayerRepository
    {   
        private FootballContext _db { get; set; }

        public FootballPlayerRepository(FootballContext db)
        {
            _db = db;
        }

        public Task<FootballPlayer> Get(int id)
        {
            return 
            _db.FootballPlayers
            .Include(player => player.FootballTeam)
            .ThenInclude(team => team.FootballCoach)
            .Include(player => player.FootballTeam)
            .ThenInclude(team => team.FootballStadiums)
            .FirstOrDefaultAsync(player => player.Id == id);
        }

        public FootballCoach AddCoach(FootballCoach coach){
            _db.FootballCoaches.AddAsync(coach);
            _db.SaveChanges();
            return coach;
        }
    }
}
