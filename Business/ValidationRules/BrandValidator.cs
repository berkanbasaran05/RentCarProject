using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Marka ismi en az 3 karakterden oluşmalı.");        
        }
    }
}
