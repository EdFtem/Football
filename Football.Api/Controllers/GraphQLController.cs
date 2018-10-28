using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Football.Api.Models;
using Football.Data.InMemory;
using GraphQL;
using GraphQL.Types;

namespace Football.Api.Controllers
{
    [Route("api/graphql")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        private FootballQuery _footballQuery { get; set; }

        public GraphQLController(FootballQuery footballQuery)
        {
            _footballQuery = footballQuery;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var schema = new Schema { Query = _footballQuery };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.ComplexityConfiguration = new ComplexityConfiguration { MaxDepth = 4 };

            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest(result.Errors);
            }

            return Ok(result);
        }
    }
}