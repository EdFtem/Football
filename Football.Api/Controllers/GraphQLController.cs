﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Football.Api.Models;
using Football.Data.InMemory;
using GraphQL;
using GraphQL.Types;
using GraphQL.Validation.Complexity;

namespace Football.Api.Controllers
{
    [Route("api/graphql")]
    [ApiController]
    public class GraphQLController : Controller
    {
        private FootballQuery _footballQuery { get; set; }

        private FootballMutation _footballMutation { get; set; }

        public GraphQLController(FootballQuery footballQuery, FootballMutation footballMutation)
        {
            _footballQuery = footballQuery;
            _footballMutation = footballMutation;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var schema = new Schema { Query = _footballQuery, Mutation = _footballMutation };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                //_.ComplexityConfiguration = new ComplexityConfiguration { MaxComplexity = 35 };

            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest(result.Errors);
            }

            return Ok(result);
        }
    }
}