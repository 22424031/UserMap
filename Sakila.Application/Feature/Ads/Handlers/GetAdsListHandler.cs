using AutoMapper;
using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.Ads;
using UserMap.Application.Dtos.Ads;
using UserMap.Application.Feature.Ads.Requests;

namespace UserMap.Application.Feature.Ads.Handlers
{
    public class GetAdsListHandler : IRequestHandler<GetAdsListRequest, BaseResponse<List<AdsDto>>>
    {
        private readonly IAdsRepository _adsRepository;
        private readonly IMapper _mapper;
        public GetAdsListHandler(IAdsRepository adsRepository, IMapper mapper)
        {
            _adsRepository = adsRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<AdsDto>>> Handle(GetAdsListRequest request, CancellationToken cancellationToken)
        {
            var rs = new BaseResponse<List<AdsDto>>();
            try
            {
                var data = await _adsRepository.GetAll();
                rs.Data = _mapper.Map<List<AdsDto>>(data);
                
            }
            catch(Exception ex)
            {
                rs.IsError = true;
                rs.ErrorMessage = ex.Message;
                rs.Status = 500;
            }
            return rs;
        }
    }
}
