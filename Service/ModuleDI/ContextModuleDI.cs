using Autofac;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ModuleDI
{
    public class ContextModuleDI:Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MyContext>().As<DbContext>().InstancePerLifetimeScope();
        }
       
    }
}
