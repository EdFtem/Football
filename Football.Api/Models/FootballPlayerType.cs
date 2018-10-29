using GraphQL.Types;
using Football.Core.Models;

namespace Football.Api.Models
{
    public class FootballPlayerType : ObjectGraphType<FootballPlayer>
    {
        public FootballPlayerType()
        {
            Field(player => player.Id).Description("The Id of the player.");
            Field(player => player.FirstName, nullable: true).Description("The first name of the player.");
            Field(player => player.SecondName, nullable: true).Description("The second name of the player.");
            Field(player => player.Age, nullable: true).Description("The age of the player.");
            Field<FootballTeamType, FootballTeam>();
        }
    }
}
