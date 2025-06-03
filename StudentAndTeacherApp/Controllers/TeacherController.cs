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
    [RoutePrefix("api/teacher")]
    public class TeacherController : ApiController
    {
        private readonly ITeacherService _teacherService;
        private readonly IMapper _mapper;

        public TeacherController(ITeacherService teacherService, IMapper mapper)
        {
            _teacherService = teacherService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<HttpResponseMessage> GetAllTeacherAsync()
        {
            try
            {
                var teachers = await _teacherService.GetAllAsync();

                var mappedTeachers=_mapper.Map<IList<TeacherRest>>(teachers);
                return Request.CreateResponse(HttpStatusCode.OK,mappedTeachers);
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }

    public class TeacherRest
    {
        public string Name { get; set; }
    }
}
