using DotnetYuzuncuYilProje.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Service.Validations
{
    public class MovieDtoValidator :AbstractValidator<MovieDto>
    {
        public MovieDtoValidator() 
        {
            RuleFor(x=>x.MovieTitle).
                NotNull().WithMessage("{PropertName} Null olmaz.")
                .NotEmpty().WithMessage("Film ismi boş bırakılamaz.");
            RuleFor(x => x.MovieReleasedDate).
                NotNull().WithMessage(" {PropertyName} Boş bırakılamaz.")
               .NotEmpty().WithMessage("Vizyon tarihi boş bırakılamaz");
        }
    }
}
