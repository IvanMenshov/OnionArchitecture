using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using StudentOnionWebApi.Domain.Interfaces;
using StudentOnionWebApi.Domain.Models;

namespace StudentOnionWebApi.Filters
{
    public class ActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var logService = GetService<IDomainLog>(actionContext);
            string rawRequest = actionContext.Request.Content.ReadAsStringAsync().Result;

            logService.LogRequest(new DomainLog()
            {
                UniversityIP = GetUniversityIPAddress(actionContext.Request),
                Controller = actionContext.ControllerContext.ControllerDescriptor.ControllerName,
                Request = rawRequest
            });
        }

        public string GetUniversityIPAddress(HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                return IPAddress.Parse(((HttpContextBase)request.Properties["MS_HttpContext"]).Request.UserHostAddress).ToString();
            }
            return String.Empty;
        }

        private T GetService<T>(HttpActionContext actioncontext)
        {
            return (T)actioncontext.Request.GetDependencyScope().GetService(typeof(T));
        }
    }
}