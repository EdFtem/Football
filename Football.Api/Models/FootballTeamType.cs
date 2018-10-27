using GraphQL.Types;
using Football.Core.Models;

namespace Football.Api.Models
{
    public class FootballTeamType : ObjectGraphType<FootballTeam>
    {
        public FootballTeamType(){
            Field(team => team.Id).Description("The id of the team.");
            Field(team => team.Name).Description("The name of the team.");
            Field(team => team.Rating).Description("The rating of the team.");
            Field<FootballCoachType, FootballCoach>().Name("footballCoach");
            Field<FootballStadiumType, FootballStadiums>().Name("footballStadiums");
        }
    }
}
