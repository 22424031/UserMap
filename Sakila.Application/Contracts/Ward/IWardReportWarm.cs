using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Dtos.Ads;
using UserMap.Application.Dtos.ReportWarm;

namespace UserMap.Application.Contracts.Ward
{
    public interface IWardReportWarm
    {
        Task<BaseResponse<bool>> PushToWard(ReportWarmDto dto);
    }
}
