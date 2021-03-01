using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
   public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(x => x.ColorName).MinimumLength(3).WithMessage("Araç rengi minimum 3 karakterden oluşmalı.");
           
        }
    }
}
