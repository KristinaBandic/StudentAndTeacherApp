using AutoMapper;
using DAL.Entities;
using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAndTeacherApp.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<SubjectSchool, ISubjectSchoolDomain>().ReverseMap();
        }
    }
}