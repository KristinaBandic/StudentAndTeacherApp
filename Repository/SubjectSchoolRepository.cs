using AutoMapper;
using DAL;
using Model;
using Model.Common;
using Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    
    public class SubjectSchoolRepository : IGenericRepository<ISubjectSchoolDomain>
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public SubjectSchoolRepository(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<IEnumerable<ISubjectSchoolDomain>> GetAllAsync()
        {
            try
            {
               
                var subjects = _context.SubjectSchools.Select(s => s).ToList();
              
                var mappingSubjects = _mapper.Map<IList<ISubjectSchoolDomain>>(subjects);
                return (Task<IEnumerable<ISubjectSchoolDomain>>)mappingSubjects;
            }
            catch (Exception ex)
            {

                throw new Exception("Error fetching data", ex);
            }
            
        }

        public Task<ISubjectSchoolDomain> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
