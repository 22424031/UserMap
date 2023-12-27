using AutoMapper;
using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.ReportWarm;
using UserMap.Application.Contracts.Ward;
using UserMap.Application.Dtos.ReportWarm;
using UserMap.Application.Feature.ReportWarms.Requests;
using UserMap.Domain;


namespace UserMap.Application.Feature.ReportWarms.Handlers
{
    public class AddReportWarmHandler : IRequestHandler<AddReportWarmRequest, BaseResponse<ReportWarmDto>>
    {
        private readonly IReportWarmRepository _reportWarmRepository;
        private readonly IMapper _mapper;
        private readonly IWardReportWarm _wardReportWarm;
        public AddReportWarmHandler(IReportWarmRepository reportWarmRepository, IMapper mapper, IWardReportWarm wardReportWarm)
        {
            _reportWarmRepository = reportWarmRepository;
            _mapper = mapper;
            _wardReportWarm = wardReportWarm;
        }

        public async Task<BaseResponse<ReportWarmDto>> Handle(AddReportWarmRequest request, CancellationToken cancellationToken)
        {
            BaseResponse<ReportWarmDto> rs = new();
            try
            {
                ReportWarm report = _mapper.Map<ReportWarm>(request.CreateReportWarmDto);
                var data = await _reportWarmRepository.Add(report);
                await _reportWarmRepository.SaveAsync();
                data.UrlString = request.CreateReportWarmDto.UrlString;
                rs.Data = _mapper.Map<ReportWarmDto>(data);
                await _wardReportWarm.PushToWard(rs.Data);

                return rs;
            }
            catch (Exception ex)
            {
                rs.IsError = true;
                rs.ErrorMessage = $"{ex.Message}, {ex.InnerException}";
                rs.Status = 500;
            }
            return rs;
        }
    }
}
