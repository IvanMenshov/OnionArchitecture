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
    public class ExceptionService : IDomainException
    {
        private readonly IException _exception;

        public ExceptionService(IException exception)
        {
            _exception = exception;
        }

        public void ExceptionRequest(DomainException exceptionInfo)
        {
            _exception.GetInformation(new ExceptionLog()
            {
                ExceptionName = exceptionInfo.ExceptionName
            });
        }
    }
}
