using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer.DTOs.AnnouncemetDTOs;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncemetValidator:AbstractValidator<AnnouncemetAddDTO>
    {
        public AnnouncemetValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Lütfen Başlık alanını boş geçmeyiniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Başlık alanını boş geçmeyiniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En az 5 karakter veri girişi yapın");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Lütfen En az 5 karakter veri girişi yapın");

        }
    }
}
