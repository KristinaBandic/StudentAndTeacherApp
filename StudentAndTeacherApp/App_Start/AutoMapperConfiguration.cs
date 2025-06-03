using AutoMapper;
using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static StudentAndTeacherApp.Controllers.SubjectSchoolController;

namespace StudentAndTeacherApp.App_Start
{
    public class AutoMapperConfiguration
    {
        public static void Init()
        {
            MapperConfiguration = new MapperConfiguration(ctf =>
            {
                ctf.CreateMap<ISubjectSchoolDomain, SubjectRest>().ReverseMap();
            });

            Mapper=MapperConfiguration.CreateMapper();
        }

        public static IMapper GetMapper()
        {
            return Mapper;
        }

        public static IMapper Mapper { get; set; }
        public static MapperConfiguration MapperConfiguration { get; set; }
    }
}