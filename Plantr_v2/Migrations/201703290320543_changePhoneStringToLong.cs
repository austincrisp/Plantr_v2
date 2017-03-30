namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changePhoneStringToLong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Souls", "Phone", c => c.Long());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Souls", "Phone", c => c.String());
        }
    }
}
