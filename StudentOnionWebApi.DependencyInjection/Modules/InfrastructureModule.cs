using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using StudentOnionWebApi.Infrastructure.Interfaces;
using StudentOnionWebApi.InfrastructureService.Repositories;

namespace StudentOnionWebApi.DependencyInjection.Modules
{
    public class InfrastructureModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IUniversity, FakeRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
