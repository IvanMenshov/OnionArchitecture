using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Domain.Interfaces;
using StudentOnionWebApi.Domain.Models;
using StudentOnionWebApi.Infrastructure.Interfaces;
using StudentOnionWebApi.Infrastructure.Models;

namespace StudentOnionWebApi.DomainService.Service
{
    public class LogService : IDomainLog
    {
        private readonly ILog _domainLog;

        public LogService(ILog domainLog)
        {
            _domainLog = domainLog;
        }

        public void LogRequest(DomainLog requestInfo)
        {
            _domainLog.GetInformation(new RequestLog()
            {
                UniversityIP = requestInfo.UniversityIP,
                Controller = requestInfo.Controller,
                Request = requestInfo.Request
            });
        }
    }
}
