using System;
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
                arguments: new QueryArguments(new QueryArgument<IdGraphType>{ Name = "id"}),
                resolve: context =>
                {
                    var id = context.GetArgument<string>("id");
                    return _footballPlayer.Get(Int32.Parse(id));
                });
        }
    }
}
