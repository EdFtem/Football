using Football.Core.Data;
using GraphQL.Types;

namespace Football.Api.Models
{
    public class FootballQuery : ObjectGraphType
    {
        private IFootballPlayerRepository _footballPlayer { get; set; }

        public FootballQuery(IFootballPlayerRepository _footballPlayer)
        {
            Field<FootballPlayerType>(
                "player", 
                resolve: context => _footballPlayer.Get(1));
        }
    }
}
