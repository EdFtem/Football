using GraphQL.Types;
using Football.Core.Models;

namespace Football.Api.Models
{
    public class FootballCoachType : ObjectGraphType<FootballCoach>
    {
        public FootballCoachType(){
            Field(coach => coach.Id).Description("The id of the coach.");
            Field(coach => coach.FirstName).Description("The first name of the coach.");
            Field(coach => coach.SecondName).Description("The second name of the coach.");
            Field(coach => coach.Age).Description("The age of the coach.");
            Field(coach => coach.Rating).Description("The rating of the coach.");
        }
    }
}
