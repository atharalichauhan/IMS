using Autofac;
using Autofac.Integration.Mvc;
using IMS.Core.Interfaces;
using IMS.Infrastructure.Data;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace IMS.App_Start
{
    public class AutofacConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<UnitOfWork>()
              .As<IUnitOfWork>()
              .InstancePerRequest();

            builder.RegisterGeneric(typeof(Repository<>))
               .As(typeof(IRepository<>)).InstancePerLifetimeScope();

            builder.RegisterType<IMSContext>()
               .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(Assembly.Load("IMS.Infrastructure"))
           .Where(t => t.Name.EndsWith("Service"))
           .AsImplementedInterfaces()
           .InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}