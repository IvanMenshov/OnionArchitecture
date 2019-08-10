using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation.Attributes;
using StudentOnionWebApi.Validators;

namespace StudentOnionWebApi.Models
{
    [Validator(typeof(StudentModelValidator))]
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}