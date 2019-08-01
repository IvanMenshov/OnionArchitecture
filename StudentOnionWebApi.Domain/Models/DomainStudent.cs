using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOnionWebApi.Domain.Models
{
    public class DomainStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
