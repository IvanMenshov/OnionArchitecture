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
    public class ExceptionRepository : IException
    {
        private readonly MyContext _context;

        public ExceptionRepository(MyContext context)
        {
            _context = context;
        }

        public void GetInformation(ExceptionLog request)
        {
            _context.ExceptionLogs.Add(request);
            _context.SaveChanges();
        }
    }
}
