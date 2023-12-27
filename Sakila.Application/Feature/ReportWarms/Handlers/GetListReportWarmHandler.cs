using AutoMapper;
using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.ReportWarm;
using UserMap.Application.Dtos.ReportWarm;
using UserMap.Application.Feature.ReportWarms.Requests;

namespace UserMap.Application.Feature.ReportWarms.Handlers
{
    public class GetListReportWarmHandler : IRequestHandler<GetListReportWarmRequest, BaseResponse<List<ReportWarmDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IReportWarmRepository _reportWarmRepository;
        public GetListReportWarmHandler(IMapper mapper, IReportWarmRepository reportWarmRepository) { 
            _mapper = mapper;
            _reportWarmRepository = reportWarmRepository;
            }
        public async Task<BaseResponse<List<ReportWarmDto>>> Handle(GetListReportWarmRequest request, CancellationToken cancellationToken)
        {
            BaseResponse<List<ReportWarmDto>> rs = new();
            var data = await _reportWarmRepository.GetAll();
            rs.Data = _mapper.Map<List<ReportWarmDto>>(data);
            return rs;
        }
    }
}
