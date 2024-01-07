using AutoMapper;
using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.Ads;
using UserMap.Application.Contracts.Ward;
using UserMap.Application.Dtos.Ads;
using UserMap.Application.Feature.Ads.Requests;

namespace UserMap.Application.Feature.Ads.Handlers
{
    public class AddAdsHandler : IRequestHandler<AddAdsRequest, BaseResponse<AdsDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAdsRepository _adsRepository;
        private readonly IWardAds _wardAds;
        public AddAdsHandler(IAdsRepository adsRepository, IMapper mapper, IWardAds wardAds)
        {
            _adsRepository = adsRepository;
            _mapper = mapper;
            _wardAds = wardAds;
        }
        public async Task<BaseResponse<AdsDto>> Handle(AddAdsRequest request, CancellationToken cancellationToken)
        {
            BaseResponse<AdsDto> rs = new();
            try
            {
              
                Domain.Ads ads = await _adsRepository.Add(_mapper.Map<Domain.Ads>(request.Ads));
                ads.IsActive = false;
                await _adsRepository.SaveChange();
                rs.Status = 200;
                rs.Data = _mapper.Map<AdsDto>(ads);
                AdsWardDto adsWard = _mapper.Map<AdsWardDto>(ads);
                var resultWard = await _wardAds.PushToWard(adsWard);
                if (resultWard.IsError)
                {
                    rs.Status = resultWard.Status;
                    rs.ErrorMessage = resultWard.ErrorMessage;
                    return rs;
                }
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
