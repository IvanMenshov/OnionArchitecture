using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation.Attributes;
using StudentOnionWebApi.Validators;

namespace StudentOnionWebApi.Models
{
    [Validator(typeof(UniversityModelValidator))]
    public class UniversityModel
    {
        public int UniversityId { get; set; }
        public string NameOfUniversity { get; set; }

        public IList<StudentModel> Students { get; set; }
    }
}