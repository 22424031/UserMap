using Microsoft.Extensions.Configuration;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.Ward;
using UserMap.Application.Dtos.Ads;

namespace WardService
{
    public class WardAds : BaseClient,IWardAds
    {
        public WardAds(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<BaseResponse<bool>> PushToWard(AdsDto dto)
        {
            return await this.PostAsync("api/ward/ReceiveAds",dto);
        }
    }
}
