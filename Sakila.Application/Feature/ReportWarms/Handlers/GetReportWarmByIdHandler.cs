using AutoMapper;
using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.ReportWarm;
using UserMap.Application.Dtos.ReportWarm;
using UserMap.Application.Feature.ReportWarms.Requests;

namespace UserMap.Application.Feature.ReportWarms.Handlers
{
    public class GetReportWarmByIdHandler : IRequestHandler<GetReportWarmByIdRequest, BaseResponse<ReportWarmDto>>
    {
        private readonly IMapper _mapper;
        private readonly IReportWarmRepository _reportWarmRepository;
        public GetReportWarmByIdHandler(IMapper mapper, IReportWarmRepository reportWarmRepository)
        {
            _mapper = mapper;
            _reportWarmRepository = reportWarmRepository;
        }

        public async Task<BaseResponse<ReportWarmDto>> Handle(GetReportWarmByIdRequest request, CancellationToken cancellationToken)
        {
            BaseResponse<ReportWarmDto> rs = new();
            if(request.id <=0)
            {
                rs.IsError = true;
                rs.ErrorMessage = "id phải lớn hơn 0";
                rs.Status = 400;
                return rs;
            }
            var data = await _reportWarmRepository.GetByID(request.id);
            rs.Data = _mapper.Map<ReportWarmDto>(data);
            return rs;
        }
    }
}
