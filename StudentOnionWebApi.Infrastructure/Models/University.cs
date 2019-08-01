using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOnionWebApi.Infrastructure.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public string NameOfUniversity { get; set; }

        public IList<Student> Students { get; set; }
    }
}
