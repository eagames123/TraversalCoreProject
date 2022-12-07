using DTOLayer.DTOs.AnnouncemetDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules.AnnouncemetValidationRules
{
    public class AnnouncemetUpdateDtoValidator:AbstractValidator<AnnouncemetUpdateDTO>
    {
        public AnnouncemetUpdateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlık alanını boş geçmeyiniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Başlık alanını boş geçmeyiniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En az 5 karakter veri girişi yapın");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen En az 5 karakter veri girişi yapın");
        }
    }
}
