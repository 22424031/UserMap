using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMap.Application.Dtos.Ads.Validators
{
    public class CreateAdsValidator : AbstractValidator<CreateAdsDto>
    {
        public CreateAdsValidator() {
            RuleFor(x => x.AdsAddress).NotEmpty().WithMessage("địa chỉ không được bỏ trống").MinimumLength(20).WithMessage("địa chỉ ít nhất 20 ký tự");
            RuleFor(x => x.Width).NotEmpty().WithMessage("chiều ngang không được bỏ trống").NotNull().WithMessage("chiều ngang không được phép null");
            RuleFor(x => x.Height).NotEmpty().WithMessage("chiều cao không được bỏ trống").NotNull().WithMessage("chiều cao không được phép null");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không được bỏ trống");
        }
    }
}
