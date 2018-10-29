using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football.Core.Data;
using Football.Core.Models;

namespace Football.Data.InMemory
{
    public class FootballPlayerRepository
    {
        private List<FootballPlayer> _footballPlayers = new List<FootballPlayer>()
        {
            new FootballPlayer() {Id = 1, FirstName = "Eduard", SecondName = "Ftemov", Age = 21 }
        };

        public Task<FootballPlayer> Get(int id)
        {
            return Task.FromResult(_footballPlayers.FirstOrDefault(player => player.Id == id));
        }
    }
}
