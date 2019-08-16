using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Infrastructure.Models;

namespace StudentOnionWebApi.Infrastructure.Interfaces
{
    public interface ILog
    {
        void GetInformation(RequestLog request);
    }
}
