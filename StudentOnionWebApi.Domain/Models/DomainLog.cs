using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOnionWebApi.Domain.Models
{
    public class DomainLog
    {
        public string UniversityIP { get; set; }
        public string Controller { get; set; }
        public string Request { get; set; }
    }
}
