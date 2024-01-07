using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMap.Application.Dtos.ReportWarm.Validators
{
    public class CreateReportWarmValidator : AbstractValidator<CreateReportWarmDto>
    {
        public CreateReportWarmValidator() { 
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không được trống");
            RuleFor(x => x.AdsID).NotNull().NotEmpty().WithMessage("AdsId không được trống");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Số điện thoại không được trống");
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Vui lòng nhập họ tên");
            RuleFor(x => x.WarmType).NotEmpty().WithMessage("Kieu bao cao không được trống");
        }
    }
}
