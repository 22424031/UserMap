using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Dtos.Ads;

namespace UserMap.Application.Contracts.Ward
{
    public interface IWardAds
    {
        Task<BaseResponse<bool>> PushToWard(CreateAdsDto dto);
    }
}
