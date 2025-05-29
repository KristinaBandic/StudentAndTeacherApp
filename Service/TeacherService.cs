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
    public class TeacherService : ITeacherService
    {
        private IGenericRepository<ITeacherDomain> genericRepository;

        public TeacherService(IGenericRepository<ITeacherDomain> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public async Task<IEnumerable<ITeacherDomain>> GetAllAsync()
        {
            try
            {
                var teachers=await genericRepository.GetAllAsync();
                return teachers;
            }
            catch (Exception ex)
            {

                throw new Exception("service error", ex);
            }
        }
    }
}
