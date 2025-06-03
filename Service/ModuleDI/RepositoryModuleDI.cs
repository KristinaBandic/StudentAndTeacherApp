using Autofac;
using DAL;
using Model.Common;
using Repository;
using Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ModuleDI
{
    public class RepositoryModuleDI:Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SubjectSchoolRepository>().As<IGenericRepository<ISubjectSchoolDomain>>();
        }
    }
}
