using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOnionWebApi.Domain.Models
{
    public class DomainUniversity
    {
        public int UniversityId { get; set; }
        public string NameOfUniversity { get; set; }

        public IList<DomainStudent> DomainStudents { get; set; }
    }
}
