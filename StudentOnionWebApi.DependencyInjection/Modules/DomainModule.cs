using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using StudentOnionWebApi.Domain.Interfaces;
using StudentOnionWebApi.DomainService.Service;

namespace StudentOnionWebApi.DependencyInjection.Modules
{
    public class DomainModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IDomainUniversity, UniversitiesService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IDomainLog, LogService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IDomainException, ExceptionService>(new ContainerControlledLifetimeManager());
        }
    }
}
