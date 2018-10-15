using GraphQL.Types;
using Football.Core.Models;

namespace Football.Api.Models
{
    public class FootballQuery : ObjectGraphType
    {
        public FootballQuery()
        {
            Field<FootballPlayerType>(
                "player", 
                resolve: context => new FootballPlayer {
                    Id = 1,
                    FirstName = "Eduard",
                    SecondName = "Ftemov",
                    Age = 21
                });
        }
    }
}
