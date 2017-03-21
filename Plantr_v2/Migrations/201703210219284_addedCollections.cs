namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCollections : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Soul_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Soul_Id");
            AddForeignKey("dbo.Courses", "Soul_Id", "dbo.Souls", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Soul_Id", "dbo.Souls");
            DropIndex("dbo.Courses", new[] { "Soul_Id" });
            DropColumn("dbo.Courses", "Soul_Id");
        }
    }
}
