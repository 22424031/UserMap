using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Dtos.ReportWarm;

namespace UserMap.Application.Feature.ReportWarms.Requests
{
    public class AddReportWarmRequest : IRequest<BaseResponse<ReportWarmDto>>
    {
        public CreateReportWarmDto CreateReportWarmDto { get; set; } = new();
    }
}
