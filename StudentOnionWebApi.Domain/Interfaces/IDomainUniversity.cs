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
        void Delete(int id);
    }
}
