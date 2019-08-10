using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using StudentOnionWebApi.Models;

namespace StudentOnionWebApi.Validators
{
    public class StudentModelValidator : AbstractValidator<StudentModel>
    {
        public StudentModelValidator()
        {
            RuleFor(_ => _.Name).NotNull().Length(1, 15);
            RuleFor(_ => _.Surname).NotNull().Length(1, 15);
        }
    }
}