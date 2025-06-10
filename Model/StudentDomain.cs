using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentDomain : IStudentDomain
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get ; set; }
        public string Class { get; set; }
        public int SubjectSchoolId { get; set; }
        public int TeacherId { get; set; }
    }
}
