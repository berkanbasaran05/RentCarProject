using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.DailyPrice).GreaterThan(0).WithMessage("Aracın günlük fiyatı 0'dan büyük olmalı.");
            RuleFor(x => x.Description).MinimumLength(5).WithMessage("Aracın açıklaması minimium 5 karakterden oluşmalı.");
            RuleFor(x => x.ModelYear).GreaterThan(0).WithMessage("Aracın modeli 0'dan büyük olmalı.");
        }
    }
}
