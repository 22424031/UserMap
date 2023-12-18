using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakila.Application.Dtos.Surfaces;
using Sakila.Application.Feature.Actor.Requests;

namespace DemoSakila.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurfacesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SurfacesController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet("GetListAsync")]
        public async Task<ActionResult<List<SurfaceDto>>> GetListAsync(int id)
        {
            var request = new GetSurfaceByIdRequest();
            request.id = id;
            var dataList = await _mediator.Send(request);
            return dataList.ToList();
        }
    }
}
