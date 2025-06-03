using Autofac;
using Autofac.Features.ResolveAnything;
using Autofac.Integration.WebApi;
using Service.ModuleDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace StudentAndTeacherApp.App_Start
{
    public class DIConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
            builder.RegisterAssemblyTypes(Assembly.Load("Service"))
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterModule(new RepositoryModuleDI());
            builder.RegisterModule(new ContextModuleDI());
           
            var container=builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}