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
            return _db.FootballPlayers.FirstOrDefaultAsync(footballPlayer => footballPlayer.Id == id);
        }
    }
}
