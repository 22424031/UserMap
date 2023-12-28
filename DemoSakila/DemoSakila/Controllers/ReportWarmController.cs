using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakila.Application.Dtos.Common;
using UserMap.Application.Contracts.Ward;
using UserMap.Application.Dtos.ReportWarm;
using UserMap.Application.Feature.ReportWarms.Requests;

namespace UserMap.API.Controllers
{
    [Route("api/[controller]")]
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
        [HttpPost("AddAsync")]
        public async Task<ActionResult<BaseResponse<ReportWarmDto>>> AddAsync([FromBody] CreateReportWarmDto createReportWarm)
        {
            var result = await _mediator.Send(new AddReportWarmRequest { CreateReportWarmDto = createReportWarm });
            return result;
        }
        [HttpGet()]
        public async Task<ActionResult<BaseResponse<List<ReportWarmDto>>>> GetListAsync()
        {
            var result = await _mediator.Send(new GetListReportWarmRequest ());

            return result;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<BaseResponse<ReportWarmDto>>> GetByIdAsync(int id)
        {
            var result = await _mediator.Send(new GetReportWarmByIdRequest { id = id});

            return result;
        }
    }
}
