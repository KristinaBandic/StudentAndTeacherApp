namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema : DbMigration
    {
        public override void Up() {
            //{
            CreateTable(
                "dbo.Students",
                c => new
                {
                    StudentId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Age = c.Int(nullable: false),
                    Class = c.String(),
                    SubjectSchoolId = c.Int(nullable: false),
                    TeacherId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.StudentId);

            CreateTable(
                "dbo.SubjectSchools",
                c => new
                {
                    SubjectSchoolId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.SubjectSchoolId);

            CreateTable(
                "dbo.Teachers",
                c => new
                {
                    TeacherId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    SubjectSchoolId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TeacherId);

            AddForeignKey("dbo.Teachers", "SubjectSchoolId", "dbo.SubjectSchools", "SubjectSchoolId");
            AddForeignKey("dbo.Students", "SubjectSchoolId", "dbo.SubjectSchools", "SubjectSchoolId");
            AddForeignKey("dbo.Students", "TeacherId", "dbo.Teachers", "TeacherId");

        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.SubjectSchools");
            DropTable("dbo.Students");
        }
    }
}
