using AutoMapper;
using Service.Common;
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
        private readonly IMapper _mapper;

        public SubjectSchoolController(ISubjectSchoolService subjectService, IMapper mapper)
        {
            _subjectService = subjectService;
            _mapper = mapper;
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
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
