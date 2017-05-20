namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAptNumberToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Souls", "AptNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Souls", "AptNumber", c => c.Int());
        }
    }
}
