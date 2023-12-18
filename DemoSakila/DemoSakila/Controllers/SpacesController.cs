using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakila.Application.Dtos.Spaces;
using Sakila.Application.Feature.Actor.Requests;

namespace DemoSakila.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpacesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SpacesController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet("GetListAsync")]
        public async Task<ActionResult<List<SpaceDto>>> GetListAsync()
        {
            var request = new GetSpaceListAsyncRequest();
            var dataList = await _mediator.Send(request);
            return dataList.ToList();
        }
    }
}
