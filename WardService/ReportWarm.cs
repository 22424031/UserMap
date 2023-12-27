using Microsoft.Extensions.Configuration;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.Ward;
using UserMap.Application.Dtos.Ads;
using UserMap.Application.Dtos.ReportWarm;

namespace WardService
{
    public class ReportWarm : BaseClient, IWardReportWarm
    {
        public ReportWarm(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<BaseResponse<bool>> PushToWard(ReportWarmDto dto)
        {
            return await this.PostAsync("api/ReportWarm/ReceiveReportWarm", dto);
        }
    }
}
