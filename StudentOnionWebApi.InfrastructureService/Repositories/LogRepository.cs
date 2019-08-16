using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Infrastructure.Interfaces;
using StudentOnionWebApi.Infrastructure.Models;
using StudentOnionWebApi.InfrastructureService.Context;

namespace StudentOnionWebApi.InfrastructureService.Repositories
{
    public class LogRepository : ILog
    {
        private readonly MyContext _context;

        public LogRepository(MyContext context)
        {
            _context = context;
        }

        public void GetInformation(RequestLog request)
        {
            _context.RequestLogs.Add(request);
            _context.SaveChanges();
        }
    }
}
