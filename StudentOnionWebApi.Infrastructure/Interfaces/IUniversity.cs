using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Infrastructure.Models;

namespace StudentOnionWebApi.Infrastructure.Interfaces
{
    public interface IUniversity
    {
        IList<University> GetAll();
        University GetById(int id);
        void Create(int id, string name);
        void Delete(int id);
    }
}
