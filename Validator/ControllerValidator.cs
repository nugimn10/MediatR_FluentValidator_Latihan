
using FluentValidation;
using MediatR_latihan.Entity;

namespace MediatR_latihan
{
     public class CreatorValidator : AbstractValidator<Creator>
    {
        public CreatorValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("nama tidak boleh kosong");
            RuleFor(x => x.age).NotEmpty().WithMessage("age tidak boleh kosong");
        }
    }
}