using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Domain.Models;
using StudentOnionWebApi.Infrastructure.Models;

namespace StudentOnionWebApi.DomainService.Mappers
{
    public static class InfrastructureToDomainStudentMapper
    {
        public static DomainStudent ToDomainStudent(this Student @this)
        {
            if (@this != null)
            {
                return new DomainStudent()
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
