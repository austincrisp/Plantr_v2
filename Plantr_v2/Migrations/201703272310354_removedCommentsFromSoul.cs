namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedCommentsFromSoul : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Souls", "Comments");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Souls", "Comments", c => c.String());
        }
    }
}
