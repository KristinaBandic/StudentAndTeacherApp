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

        public async Task<ISubjectSchoolDomain> CreateSubjectAsync(ISubjectSchoolDomain subject)
        {
            try
            {
             return await genericRepository.CreateAsync(subject);

             
            }
            catch (Exception ex)
            {

                throw new Exception("Error - Post subject", ex);
            }
        }

        public async Task<string> CreateSubjectWithNameAsync(string name)
        {
            return await genericRepository.CreateWithNameAsync(name);
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
