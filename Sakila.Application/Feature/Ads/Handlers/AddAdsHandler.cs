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
    public class AddAdsHandler : IRequestHandler<AddAdsRequest, BaseResponse<AdsDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAdsRepository _adsRepository;
        public AddAdsHandler(IAdsRepository adsRepository, IMapper mapper)
        {
            _adsRepository = adsRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<AdsDto>> Handle(AddAdsRequest request, CancellationToken cancellationToken)
        {
            BaseResponse<AdsDto> rs = new();
            try
            {
              Domain.Ads ads = await _adsRepository.Add(_mapper.Map<Domain.Ads>(request.Ads));
                rs.Status = 200;
                rs.Data = _mapper.Map<AdsDto>(ads);
               
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
