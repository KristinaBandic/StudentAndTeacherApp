using AutoMapper;
using DAL;
using Model;
using Model.Common;
using Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    
    public class SubjectSchoolRepository : IGenericRepository<ISubjectSchoolDomain>
    {
        private MyContext _context;
        private IMapper _mapper;

        public SubjectSchoolRepository(MyContext context)
        {
            var baseDir=AppDomain.CurrentDomain.BaseDirectory;
            var parentDir = Directory.GetParent(baseDir);
            var path = parentDir.Parent.FullName.ToString();
            var fullPath = Path.GetFullPath(path);
            AppDomain.CurrentDomain.SetData("DataDirectory", fullPath);
            _context = context;
         

        }

        public Task<IEnumerable<ISubjectSchoolDomain>> GetAllAsync()
        {
            try
            {
               
                var subjects = _context.SubjectSchools.Select(s => s).ToList();
              
                var mapped=new List<ISubjectSchoolDomain>();
             

                foreach (var item in subjects)
                {
                    var subject = new SubjectSchoolDomain();
                    subject.SubjectSchoolId = item.SubjectSchoolId;
                    subject.Name= item.Name;
                    mapped.Add(subject);
                }
                //var mappingSubjects = _mapper.Map<IList<ISubjectSchoolDomain>>(subjects);
                return Task.FromResult(mapped.AsEnumerable<ISubjectSchoolDomain>());
            }
            catch (Exception ex)
            {

                throw new Exception("Error fetching data", ex.InnerException);
            }
            
        }

        public Task<ISubjectSchoolDomain> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
