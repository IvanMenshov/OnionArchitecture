using Microsoft.Practices.Unity;
using StudentOnionWebApi.DependencyInjection;
using System.Web.Http;
using StudentOnionWebApi.DependencyInjection.Modules;
using Unity.WebApi;

namespace StudentOnionWebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            Register<DomainModule>(container);
            Register<InfrastructureModule>(container);
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        private static void Register<T>(IUnityContainer container) where T : IModule, new()
        {
            new T().Register(container);
        }
    }
}