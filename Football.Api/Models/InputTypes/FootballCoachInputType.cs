using GraphQL.Types;
using Football.Core.Models;

namespace Football.Api.Models
{
    public class FootballCoachInputType : InputObjectGraphType<FootballCoach>
    {
        public FootballCoachInputType(){
            Name = "CoachInput";
            Field(coach => coach.Id).Name("id").Description("The id of the coach.");
            Field(coach => coach.FirstName).Name("firstName").Description("The first name of the coach.");
            Field(coach => coach.SecondName).Name("secondName").Description("The second name of the coach.");
            Field(coach => coach.Age).Name("age").Description("The age of the coach.");
            Field(coach => coach.Rating).Name("rating").Description("The rating of the coach.");
        }
    }
}
