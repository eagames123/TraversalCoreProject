using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen Ad Soyad Giriniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz.");
            //RuleFor(x => x.Image).MinimumLength(50).WithMessage("Lütfen görsel girin.");
            //RuleFor(x => x.TwitterUrl).MaximumLength(1500).WithMessage("Lütfen Açıklamayı kısaltın.");
            //RuleFor(x => x.InstagramUrl).MaximumLength(1500).WithMessage("Lütfen Açıklamayı kısaltın.");
        }
    }
}
