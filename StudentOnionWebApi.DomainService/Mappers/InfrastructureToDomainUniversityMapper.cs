using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Domain.Models;
using StudentOnionWebApi.Infrastructure.Models;

namespace StudentOnionWebApi.DomainService.Mappers
{
    public static class InfrastructureToDomainUniversityMapper
    {
        public static DomainUniversity ToDomainUniversity(this University @this)
        {
            if (@this.Students != null)
            {
                return new DomainUniversity
                {
                    UniversityId = @this.UniversityId,
                    NameOfUniversity = @this.NameOfUniversity,
                    DomainStudents = @this.Students.Select(_ => _.ToDomainStudent()).ToList()
                };
            }
            else
            {
                return new DomainUniversity
                {
                    UniversityId = @this.UniversityId,
                    NameOfUniversity = @this.NameOfUniversity,
                    DomainStudents = null
                };
            }
        }
    }
}
