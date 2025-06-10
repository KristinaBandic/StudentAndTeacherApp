using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SubjectSchoolDomain : ISubjectSchoolDomain
    {
        public int SubjectSchoolId { get ; set ; }
        public string Name { get; set; }
    }
}
