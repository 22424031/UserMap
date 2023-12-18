using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakila.Application.Dtos.Common;
using UserMap.Application.Dtos.Ads;
using UserMap.Application.Feature.Ads.Requests;

namespace UserMap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        private IMediator _mediator;
        public AdsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("AddAdsAsync")]
        public async Task<ActionResult<BaseResponse<AdsDto>>> AddAdsAsync([FromBody] CreateAdsDto ads)
        {
            BaseResponse<AdsDto> rs = new();
            rs = await _mediator.Send(new AddAdsRequest { Ads = ads });
            return rs;
        }
    }
}
