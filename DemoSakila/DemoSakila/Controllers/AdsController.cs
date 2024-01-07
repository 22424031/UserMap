using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakila.Application.Dtos.Common;
using UserMap.Application.Dtos.Ads;
using UserMap.Application.Dtos.Ads.Validators;
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
        /// <summary>
        /// Add ads new
        /// </summary>
        /// <param name="ads"></param>
        /// <returns></returns>
        /// <responses status="401">authoriztion</responses>
        /// <responses status="500">Error Internal server</responses>
        /// <responses status="400">request data bad request</responses>
        /// <responses status="200">send Ads have data ok</responses>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpPost("AddAdsAsync")]
  
        public async Task<ActionResult<BaseResponse<AdsDto>>> AddAdsAsync([FromBody] CreateAdsDto ads)
        {
            var rs = new BaseResponse<AdsDto>();
            
            var createAdsValidator = new CreateAdsValidator();
            var validResult = createAdsValidator.Validate(ads);
            if (!validResult.IsValid)
            {
                rs.IsError = true;
                rs.Status = 400;
                rs.ErrorMessage = string.Join(",", validResult.Errors.Select(x => x.ErrorMessage).ToArray());
                return rs;
            }
            
            
            rs = await _mediator.Send(new AddAdsRequest { Ads = ads });
            
            return rs;
        }
        /// <summary>
        /// Add ads new
        /// </summary>
        /// <param name="ads"></param>
        /// <returns></returns>
        /// <responses status="401">authoriztion</responses>
        /// <responses status="500">Error Internal server</responses>
        /// <responses status="204">No content</responses>
        /// <responses status="200">send Ads have data ok</responses>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpGet("GetListAsync")]
     
        public async Task<ActionResult<BaseResponse<List<AdsDto>>>> GetListAsync()
        {
            BaseResponse<List<AdsDto>> rs = new();
            rs = await _mediator.Send(new GetAdsListRequest());
            return Ok(rs);

        }
        /// <summary>
        /// Get ADs by ADSID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <responses status="500">Error Internal server</responses>
        /// <responses status="204">No content</responses>
        /// <responses status="200">Result have data</responses>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("GetByAdsIDAsync")]
        public async Task<ActionResult<BaseResponse<AdsDto>>> GetByAdsIDAsync(int id)
        {
            BaseResponse<AdsDto> rs = new();
            rs = await _mediator.Send(new GetAdsByIDRequest { adsID = id});
            if (rs.Data is null) return Ok(rs);
            return rs;
        }
    }
}
