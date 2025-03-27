using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyContext:DbContext
    {
        public MyContext() : base("STSDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyContext, DAL.Migrations.Configuration>("STSDB"));
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SubjectSchool> SubjectSchools { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
