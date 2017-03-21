namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedCourseCollectionFromSoul : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Soul_Id", "dbo.Souls");
            DropIndex("dbo.Courses", new[] { "Soul_Id" });
            DropColumn("dbo.Courses", "Soul_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Soul_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Soul_Id");
            AddForeignKey("dbo.Courses", "Soul_Id", "dbo.Souls", "Id");
        }
    }
}
