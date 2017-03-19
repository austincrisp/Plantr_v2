namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnswerModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Body = c.String(),
                        SoulId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Souls", t => t.SoulId, cascadeDelete: true)
                .Index(t => t.SoulId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "SoulId", "dbo.Souls");
            DropForeignKey("dbo.Answers", "CourseId", "dbo.Courses");
            DropIndex("dbo.Answers", new[] { "CourseId" });
            DropIndex("dbo.Answers", new[] { "SoulId" });
            DropTable("dbo.Answers");
        }
    }
}
