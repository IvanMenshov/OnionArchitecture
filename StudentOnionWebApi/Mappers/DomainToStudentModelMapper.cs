using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentOnionWebApi.Domain.Models;
using StudentOnionWebApi.Models;

namespace StudentOnionWebApi.Mappers
{
    public static class DomainToStudentModelMapper
    {
        public static StudentModel ToStudentModel(this DomainStudent @this)
        {
            if (@this != null)
            {
                return new StudentModel()
                {
                    StudentId = @this.StudentId,
                    Name = @this.Name,
                    Surname = @this.Surname
                };
            }
            else
            {
                return null;
            }
        }
    }
}