using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Dtos.SubWard;

namespace UserMap.Application.Feature.Ads.Requests
{
    public class UpdateAdsStatusRequest : IRequest<BaseResponse<bool>>
    {
        public StatusFeedbackDto StatusFeedbackDto { get; set; }
    }
}
