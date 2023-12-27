﻿using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Dtos.ReportWarm;

namespace UserMap.Application.Feature.ReportWarms.Requests
{
    public class GetListReportWarmRequest : IRequest<BaseResponse<List<ReportWarmDto>>>
    {
    }
}