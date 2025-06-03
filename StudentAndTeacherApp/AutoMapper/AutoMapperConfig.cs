using AutoMapper;
using DAL.Entities;
using Model;
using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static StudentAndTeacherApp.Controllers.SubjectSchoolController;

namespace StudentAndTeacherApp.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<SubjectSchool, SubjectSchoolDomain>().ReverseMap();
            CreateMap<SubjectSchoolDomain, SubjectRest>().ReverseMap();
        }
    }
}