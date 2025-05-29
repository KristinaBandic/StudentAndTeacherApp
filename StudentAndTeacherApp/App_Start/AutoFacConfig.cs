using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StudentAndTeacherApp.App_Start
{
    public class AutoFacConfig
    {
        public static void Register()
        {
            var blds = new ContainerBuilder();
            var config=GlobalConfiguration.Configuration;
            blds.RegisterAssemblyModules();
           
        }
        private static void RegisterServices(ContainerBuilder containerBuilder)
        {
            var config = new MapperConfiguration(ctf => { ctf.AddProfile(new AutoMapper.MappingProfile()); });
        }
    }
}