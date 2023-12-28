using MediatR;
using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.Ads;
using UserMap.Application.Feature.Ads.Requests;

namespace UserMap.Application.Feature.Ads.Handlers
{
    public class UpdateAdsStatusHandler : IRequestHandler<UpdateAdsStatusRequest, BaseResponse<bool>>
    {
        private readonly IAdsRepository _adsRepository;
        public UpdateAdsStatusHandler(IAdsRepository adsRepository)
        {
            _adsRepository = adsRepository;
        }
        public async Task<BaseResponse<bool>> Handle(UpdateAdsStatusRequest request, CancellationToken cancellationToken)
        {
            BaseResponse<bool> rs = new();
            var ads = await _adsRepository.GetAdsById(request.StatusFeedbackDto.Id);
            try
            {
                if (ads != null)
                {
                    ads.Feedback = request.StatusFeedbackDto.Comment;
                    ads.Status = request.StatusFeedbackDto.Status;
                    await _adsRepository.Update(ads);
                    await _adsRepository.SaveChange();
                    rs.Data = true;

                }
            }
            catch (Exception ex)
            {
                rs.IsError = true;
                rs.Data = false;    
                rs.ErrorMessage = ex.Message;

            }
            return rs;
        }
    }
}
