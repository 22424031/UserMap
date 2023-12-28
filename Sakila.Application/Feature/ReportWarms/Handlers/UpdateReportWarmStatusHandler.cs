using MediatR;
using Sakila.Application.Dtos.Common;
using UserMap.Application.Contracts.ReportWarm;
using UserMap.Application.Feature.ReportWarms.Requests;


namespace UserMap.Application.Feature.ReportWarms.Handlers
{
    public class UpdateReportWarmStatusHandler : IRequestHandler<UpdateReportWarmStatusRequest, BaseResponse<bool>>
    {
        private readonly IReportWarmRepository _repository;

        public UpdateReportWarmStatusHandler(IReportWarmRepository repository) {
                _repository = repository;
        }

        public async Task<BaseResponse<bool>> Handle(UpdateReportWarmStatusRequest request, CancellationToken cancellationToken)
        {
            BaseResponse<bool> rs = new();
            try
            {
                var data = await _repository.GetByID(request.StatusFeedback.Id);
                if(data == null)
                {
                    rs.Status = 204;
                    rs.ErrorMessage = "ReportWarmID not found in database";
                    
                }
                data.Status = request.StatusFeedback.Status;
                data.Feedback = request.StatusFeedback.Comment;
                await _repository.Update(data);
                await _repository.SaveAsync();
           
            }
            catch (Exception ex)
            {
                rs.IsError = true;
                rs.ErrorMessage = ex.Message;
                rs.Status = 500;
            }
            return rs;
        }
    }
}
