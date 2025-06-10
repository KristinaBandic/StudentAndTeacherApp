using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class TeacherDomain : ITeacherDomain
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public int SubjectSchoolId { get; set; }
    }
}
