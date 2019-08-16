using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Domain.Models;

namespace StudentOnionWebApi.Domain.Interfaces
{
    public interface IDomainLog
    {
        void LogRequest(DomainLog requestInfo);
    }
}
