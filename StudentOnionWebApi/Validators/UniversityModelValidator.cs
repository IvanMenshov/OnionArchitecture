using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using StudentOnionWebApi.Models;

namespace StudentOnionWebApi.Validators
{
    public class UniversityModelValidator : AbstractValidator<UniversityModel>
    {
        public UniversityModelValidator()
        {
            RuleFor(_ => _.NameOfUniversity).NotNull().Length(3,7);
        }
    }
}