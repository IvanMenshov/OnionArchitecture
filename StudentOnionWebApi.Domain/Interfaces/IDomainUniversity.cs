using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Domain.Models;

namespace StudentOnionWebApi.Domain.Interfaces
{
    public interface IDomainUniversity
    {
        IList<DomainUniversity> GetAll();
        DomainUniversity GetById(int id);
        void Create(int id, string name);
        void CreateStudent(int? domainUniversityId, int domainStudentId, string name, string surname);
        void Delete(int id);
    }
}
