using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Dtos.Ads;
using UserMap.Domain;

namespace UserMap.Application.Feature.Ads.Requests
{
    public class AddAdsRequest : IRequest<BaseResponse<AdsDto>>
    {
        public CreateAdsDto Ads { get; set; }
    }
}
