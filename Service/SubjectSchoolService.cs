using Model.Common;
using Repository.Common;
using Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SubjectSchoolService : ISubjectSchoolService
    {
        private IGenericRepository<ISubjectSchoolDomain> genericRepository;

        public SubjectSchoolService(IGenericRepository<ISubjectSchoolDomain> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public async Task<IEnumerable<ISubjectSchoolDomain>> GetAllAsync()
        {
            try
            {
                var subjects=await genericRepository.GetAllAsync();
                return subjects;
            }
            catch (Exception ex)
            {

                throw new Exception("Error - get all subjects", ex);
            }
        }
    }
}
