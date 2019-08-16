using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOnionWebApi.Infrastructure.Models
{
    public class RequestLog
    {
        public int RequestId { get; set; }
        public string UniversityIP { get; set; }
        public string Controller { get; set; }
        public string Request { get; set; }
    }
}
