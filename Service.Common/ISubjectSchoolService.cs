using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common
{
    public interface ISubjectSchoolService
    {
        Task<IEnumerable<ISubjectSchoolDomain>> GetAllAsync();
        Task<ISubjectSchoolDomain> CreateSubjectAsync(ISubjectSchoolDomain subject);

        Task<string> CreateSubjectWithNameAsync(string name);
    }
}
