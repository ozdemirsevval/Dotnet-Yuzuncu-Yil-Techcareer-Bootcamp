using DotnetYuzuncuYilProje.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Service.Validations
{
    public class AudienceDtoValidator : AbstractValidator<AudienceDto>
    {
        public AudienceDtoValidator() 
        {
            RuleFor(x=>x.FirstName).
                NotEmpty().WithMessage("İsim boş bırakılamaz.")
               .NotNull().WithMessage("İsim null olamaz.")
               .MaximumLength(50).WithMessage("50 karakteri geçemez.") ;
            RuleFor(x => x.LastName).
                NotEmpty().WithMessage("Soyisim boş bırakılamaz.")
               .NotNull().WithMessage("Soyisim null olamaz.")
               .MaximumLength(50).WithMessage("50 karakteri geçemez.");
            RuleFor(x => x.Email).
                NotEmpty().WithMessage("Email boş bırakılamaz.")
               .NotNull().WithMessage("Email null olamaz.")
               .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");

        }
    }
}
