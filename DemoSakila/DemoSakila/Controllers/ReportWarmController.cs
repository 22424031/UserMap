using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakila.Application.Dtos.Common;
using UserMap.Application.Contracts.Ward;
using UserMap.Application.Dtos.ReportWarm;
using UserMap.Application.Dtos.ReportWarm.Validators;
using UserMap.Application.Feature.ReportWarms.Requests;

namespace UserMap.API.Controllers
{
    [Route("UserMap")]
    [ApiController]
    public class ReportWarmController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReportWarmController(IMediator mediator)
        {
            _mediator = mediator;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="createReportWarm"></param>
        /// <remarks>
        /// request sample
        /// {
        ///"warmType": "Giải đáp thắc mắc",
        /// "fullName": "string",
        /// "email": "string",
        /// "phoneNumber": "string",
        /// "comment": "string",
        ///"urlString": [
        /// "string"
        ///],
        ///"adsID": 0,
        /// "status": "string"
        ///}
        /// 
        /// </remarks>
        /// <returns></returns>
        /// <responses status="401">authoriztion</responses>
        /// <responses status="500">Error Internal server</responses>
        /// <responses status="400">request data bad request</responses>
        /// <responses status="200">send report has data ok</responses>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost("AddReportAsync")]
        public async Task<ActionResult<BaseResponse<ReportWarmDto>>> AddReportAsync([FromBody] CreateReportWarmDto createReportWarm)
        {
            BaseResponse<ReportWarmDto> rs = new();
            var validator = new CreateReportWarmValidator();
            var resultValidator = validator.Validate(createReportWarm);
            if (!resultValidator.IsValid)
            {
                rs.IsError = true;
                rs.Status = 400;
                rs.ErrorMessage = string.Join(", ", resultValidator.Errors.Select(x => x.ErrorMessage));
            }
            var result = await _mediator.Send(new AddReportWarmRequest { CreateReportWarmDto = createReportWarm });
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="createReportWarm"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        /// <responses status="401">authoriztion</responses>
        /// <responses status="500">Error Internal server</responses>
        /// <responses status="204">no record</responses>
        /// <responses status="200">send report has data ok</responses>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet()]
        public async Task<ActionResult<BaseResponse<List<ReportWarmDto>>>> GetReportListAsync()
        {
            var result = await _mediator.Send(new GetListReportWarmRequest ());
            return result;
        }
        /// <summary>
        /// Get By ReportWarmID
        /// </summary>
        /// <param name="id">1</param>
        /// <returns></returns>
        /// <responses status="401">authoriztion</responses>
        /// <responses status="500">Error Internal server</responses>
        /// <responses status="204">no record</responses>
        /// <responses status="200">Get ok</responses>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public async Task<ActionResult<BaseResponse<ReportWarmDto>>> GetReportByIdAsync(int id)
        {
            var result = await _mediator.Send(new GetReportWarmByIdRequest { id = id });
            return result;
        }
    }
}
