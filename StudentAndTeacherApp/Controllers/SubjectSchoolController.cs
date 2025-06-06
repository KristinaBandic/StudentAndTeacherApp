using AutoMapper;
using Service;
using Service.Common;
using StudentAndTeacherApp.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace StudentAndTeacherApp.Controllers
{
    [RoutePrefix("api/subjectschool")]
    public class SubjectSchoolController : ApiController
    {
        private readonly ISubjectSchoolService _subjectService;
        private IMapper _mapper=AutoMapperConfiguration.GetMapper();

        public SubjectSchoolController(ISubjectSchoolService subjectService)
        {
            _subjectService = subjectService;
      
        }
        [HttpGet]
        public async Task<HttpResponseMessage> GetSubjectsAsync()
        {
            try
            {
                var subjects = await _subjectService.GetAllAsync();
                var mappingSubjects = _mapper.Map<List<SubjectRest>>(subjects);
                return Request.CreateResponse(HttpStatusCode.OK,mappingSubjects);
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

        public class SubjectRest
        {
            public int SubjectSchoolId { get; set; }
            public string Name { get; set; }
        }
    }
}
