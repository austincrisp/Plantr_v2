namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedPhoneBackToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Souls", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Souls", "Phone", c => c.Long());
        }
    }
}
