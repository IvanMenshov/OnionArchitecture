using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using StudentOnionWebApi.Domain.Interfaces;
using StudentOnionWebApi.Domain.Models;

namespace StudentOnionWebApi.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var exceptionMessage = actionExecutedContext.Exception.InnerException == null 
                ? actionExecutedContext.Exception.Message.ToString() : actionExecutedContext.Exception.InnerException.Message.ToString();

            var exceptionServices = (IDomainException)actionExecutedContext.Request.GetDependencyScope().GetService(typeof(IDomainException));
            exceptionServices.ExceptionRequest(new DomainException()
            {
                ExceptionName = exceptionMessage
            });
        }
    }
}