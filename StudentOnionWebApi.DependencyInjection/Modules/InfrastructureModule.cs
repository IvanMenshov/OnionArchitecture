using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
using StudentOnionWebApi.Infrastructure.Interfaces;
using StudentOnionWebApi.InfrastructureService.Context;
using StudentOnionWebApi.InfrastructureService.Repositories;

namespace StudentOnionWebApi.DependencyInjection.Modules
{
    public class InfrastructureModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);

            using (var context = new MyContext(optionsBuilder.Options))
                context.Database.EnsureCreated();


            container.RegisterType<MyContext>(new ContainerControlledLifetimeManager(),
                new InjectionConstructor(optionsBuilder.Options));
            container.RegisterType<IUniversity, UniversityRepository>(new ContainerControlledLifetimeManager());

            container.RegisterType<ILog, LogRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IException, ExceptionRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
