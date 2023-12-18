using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Dtos.Ads;

namespace UserMap.Application.Feature.Ads.Requests
{
    public class GetAdsByIDRequest : IRequest<BaseResponse<AdsDto>>
    {
        public int adsID { get; set; }
    }
}
