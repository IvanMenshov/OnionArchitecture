using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentOnionWebApi.Domain.Models;
using StudentOnionWebApi.Models;

namespace StudentOnionWebApi.Mappers
{
    public static class DomainToUniversityModelMapper
    {
        public static UniversityModel ToUniversityModel(this DomainUniversity @this)
        {
            if (@this.DomainStudents != null)
            {
                return new UniversityModel()
                {
                    UniversityId = @this.UniversityId,
                    NameOfUniversity = @this.NameOfUniversity,
                    Students = @this.DomainStudents.Select(_ => _.ToStudentModel()).ToList()
                };
            }
            else
            {
                return new UniversityModel
                {
                    UniversityId = @this.UniversityId,
                    NameOfUniversity = @this.NameOfUniversity,
                    Students = null
                };
            }
        }
    }
}