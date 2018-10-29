using System;
using Football.Core.Data;
using Football.Core.Models;
using GraphQL.Types;

namespace Football.Api.Models
{
    public class FootballMutation : ObjectGraphType
    {
        private IFootballPlayerRepository _footballPlayer { get; set; }

        public FootballMutation(IFootballPlayerRepository _footballPlayer)
        {
            Field<FootballCoachType>(
            "createCoach", 
            arguments: new QueryArguments(new QueryArgument<FootballCoachInputType> { Name = "coach" }),
            resolve: context =>
            {
                var coach = context.GetArgument<FootballCoach>("coach");
                return _footballPlayer.AddCoach(coach);
            });
        }
    }
}
