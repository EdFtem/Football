using GraphQL.Types;
using Football.Core.Models;

namespace Football.Api.Models
{
    public class FootballStadiumType : ObjectGraphType<FootballStadiums>
    {
        public FootballStadiumType(){
            Field(stadium => stadium.Id).Description("The id of the stadium.");
            Field(stadium => stadium.Name).Description("The name of the stadium.");
            Field(stadium => stadium.Rating).Description("The rating of the stadium.");
        }
    }
}
