using ETrade.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.NameSurname).NotEmpty().WithMessage("Ad Soyad boş bırakılamaz!");
            RuleFor(c => c.NameSurname).MaximumLength(25);
            RuleFor(c => c.NameSurname).MinimumLength(5);
            RuleFor(c => c.Email).NotEmpty().WithMessage("Email boş bırakılamaz!");
            RuleFor(c => c.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");
            RuleFor(c => c.Gender).NotEmpty();
            RuleFor(c => c.BirthDate).NotEmpty();
            RuleFor(c => c.TelNr1).NotEmpty();
            RuleFor(c => c.TelNr1).Must(StartWith);
            RuleFor(c => c.TelNr1).MinimumLength(11).MaximumLength(11).WithMessage("Telefon numarası 05351112233 şeklinde olmalıdır.");
        }

        private bool StartWith(string arg)
        {
            return arg.StartsWith("05");
        }
    }
}
