using AutoMapper;
using DAL;
using Model.Common;
using Repository.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TeacherRepository : IGenericRepository<ITeacherDomain>
    {
        private readonly MyContext _myContext;
        private readonly IMapper _mapper;

       public TeacherRepository(MyContext myContext)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var parentDir = Directory.GetParent(baseDir);
            var path = parentDir.Parent.FullName.ToString();
            var fullPath = Path.GetFullPath(path);
            AppDomain.CurrentDomain.SetData("DataDirectory", fullPath);
            _myContext = myContext;
        }

        public Task<IEnumerable<ITeacherDomain>> GetAllAsync()
        {
            try
            {
                var teachers = _myContext.Teachers.Select(s => s).ToList();

                var mappedTeachers=_mapper.Map<IList<ITeacherDomain>>(teachers);
                return (Task<IEnumerable<ITeacherDomain>>)mappedTeachers;
            }
            catch (Exception ex)
            {

                throw new Exception("Error by fetching,", ex);
            }
        }

        public Task<ITeacherDomain> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
