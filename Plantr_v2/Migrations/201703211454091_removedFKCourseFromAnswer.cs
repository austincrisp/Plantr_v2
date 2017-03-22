namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedFKCourseFromAnswer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Answers", "CourseId", "dbo.Courses");
            DropIndex("dbo.Answers", new[] { "CourseId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Answers", "CourseId");
            AddForeignKey("dbo.Answers", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}
