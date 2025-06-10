using AutoMapper;
using Model.Common;
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

        [HttpPost]
        public async Task<HttpResponseMessage> PostSubjectAsync([FromBody] SubjectRest subjectRest)
        {
            try
            {
                var domainModel = _mapper.Map<ISubjectSchoolDomain>(subjectRest);
                await _subjectService.CreateSubjectAsync(domainModel);
                return Request.CreateResponse(HttpStatusCode.OK, subjectRest);
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
         
        }

        [HttpPost]
        [Route("naziv")]
        public async Task<HttpResponseMessage> PostSubjectWithNameAsync([FromBody]string name)
        {
            try
            {
              
                await _subjectService.CreateSubjectWithNameAsync(name);
                return Request.CreateResponse(HttpStatusCode.OK, name);
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
