using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using DAL.Entities;
using Model.Common;
using Repository;
using Repository.Common;
using Service;
using Service.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace StudentAndTeacherApp.App_Start
{
    public class AutoFacConfig
    {
        public static void Initialize(HttpConfiguration config)
        {

            config.DependencyResolver = new AutofacWebApiDependencyResolver(
                RegisterServices(new ContainerBuilder())
            );
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            //deal with your dependencies here
            builder.RegisterType<SubjectSchoolService>().As<ISubjectSchoolService>();
            builder.RegisterType<SubjectSchoolRepository>().As<IGenericRepository<ISubjectSchoolDomain>>();
            builder.RegisterType<DbContext>().SingleInstance();

            return builder.Build();
        }




    
    }
}