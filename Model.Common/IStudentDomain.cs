using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public interface IStudentDomain
    {
        int StudentId { get; set; }
        string Name { get; set; }
        int Age { get; set; }
       string Class { get; set; }
        int SubjectSchoolId { get; set; }
        int TeacherId { get; set; }
    }
}
