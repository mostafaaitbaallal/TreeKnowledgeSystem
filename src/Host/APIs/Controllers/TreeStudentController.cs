using MediatR;
using Microsoft.AspNetCore.Mvc;
using TreeKnowledgeSystem.Application.Commands;
using TreeKnowledgeSystem.Application.Responses;
using TreeKnowledgeSystem.Application.Queries;
using TreeKnowledgeSystem.Domain.Entities;
using TreeKnowledgeSystem.Infrastructure.Repositories;


namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreeStudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TreeStudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<TreeStudent>> Get()
        {
            return (List<TreeStudent>)await _mediator.Send(new GetAllTreeStudentQuery());
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<TreeStudentResponse>> CreateTreeStudent([FromBody] CreateTreeStudentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
