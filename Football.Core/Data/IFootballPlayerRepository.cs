using System.Threading.Tasks;
using Football.Core.Models;

namespace Football.Core.Data
{
    public interface IFootballPlayerRepository
    {
        Task<FootballPlayer> Get(int id);

        FootballCoach AddCoach(FootballCoach coach);
    }
}
