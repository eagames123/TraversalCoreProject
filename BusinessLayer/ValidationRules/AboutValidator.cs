using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen En az 50 karakterlik açıklama girin.");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen Açıklamayı kısaltın.");
        }
    }
}
