using AutoMapper;
using DAL;
using Model.Common;
using Repository.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StudentRepository : IGenericRepository<IStudentDomain>
    {
        private MyContext _context;
        private IMapper _mapper;

        public StudentRepository(MyContext context)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var parentDir = Directory.GetParent(baseDir);
            var path = parentDir.Parent.FullName.ToString();
            var fullPath = Path.GetFullPath(path);
            AppDomain.CurrentDomain.SetData("DataDirectory", fullPath);
            _context = context;


        }
        public Task<IEnumerable<IStudentDomain>> GetAllAsync()
        {
            try
            {

                var students = _context.Students.Select(s => s).ToList();

                var mappingStudents = _mapper.Map<IList<IStudentDomain>>(students);
                return (Task<IEnumerable<IStudentDomain>>)mappingStudents;
            }
            catch (Exception ex)
            {

                throw new Exception("Error fetching data", ex);
            }
        }

        public Task<IStudentDomain> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
