using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using MicroServiceMCQ.Application.QuestionTypeManage.Commands.CreateQuestionType;
using MicroServiceMCQ.Application.QuestionTypeManage.Models;
using MicroServiceMCQ.Application.QuestionTypeManage.Queries.GetQuestionType;
using MicroServiceMCQ.Application.QuestionTypeManage.Queries.GetQuestionTypesList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroServiceMCQ.WebApi.Controllers
{
    public class QuestionTypeController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<QuestionTypeDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetQuestionTypesListQuery()));
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(IEnumerable<QuestionTypeDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetQuestionTypeQuery() { Id = id }));
        }
    }
}