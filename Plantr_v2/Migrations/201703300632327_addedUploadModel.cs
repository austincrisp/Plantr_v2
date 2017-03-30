namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedUploadModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uploads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        File = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uploads");
        }
    }
}
