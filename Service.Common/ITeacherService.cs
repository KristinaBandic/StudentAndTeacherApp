using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common
{
    public interface ITeacherService
    {
        Task<IEnumerable<ITeacherDomain>> GetAllAsync();
    }
}
