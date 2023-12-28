using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakila.Application.Dtos.Common;
using UserMap.Application.Dtos.SubWard;
using UserMap.Application.Feature.Ads.Requests;
using UserMap.Application.Feature.ReportWarms.Requests;

namespace UserMap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubWardController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SubWardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("StatusFeedback")]
        public async Task<ActionResult<BaseResponse<bool>>> StatusFeedback(StatusFeedbackDto feedbackDto)
        {
            var data = await _mediator.Send(new UpdateAdsStatusRequest { StatusFeedbackDto = feedbackDto});
            return data;
        }
        [HttpPost("StatusReportWarmFeedback")]
        public async Task<ActionResult<BaseResponse<bool>>> StatusReportWarmFeedback(StatusFeedbackDto feedbackDto)
        {
            var data = await _mediator.Send(new UpdateReportWarmStatusRequest { StatusFeedback = feedbackDto });
            return data;
       
        }
    }
}
