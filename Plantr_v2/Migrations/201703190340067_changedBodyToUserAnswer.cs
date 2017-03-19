namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedBodyToUserAnswer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answers", "UserAnswer", c => c.String());
            DropColumn("dbo.Answers", "Body");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Answers", "Body", c => c.String());
            DropColumn("dbo.Answers", "UserAnswer");
        }
    }
}
