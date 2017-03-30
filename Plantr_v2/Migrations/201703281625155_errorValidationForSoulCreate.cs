namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class errorValidationForSoulCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Souls", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Souls", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Souls", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Souls", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Souls", "City", c => c.String());
            AlterColumn("dbo.Souls", "Address", c => c.String());
            AlterColumn("dbo.Souls", "LastName", c => c.String());
            AlterColumn("dbo.Souls", "FirstName", c => c.String());
        }
    }
}
