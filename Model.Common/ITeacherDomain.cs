using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public interface ITeacherDomain
    {
       int TeacherId { get; set; }
       string Name { get; set; }
       int SubjectSchoolId { get; set; }
    }
}
