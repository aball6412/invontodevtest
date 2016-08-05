namespace InvontoDevTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeFieldsNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Phone", c => c.Int());
            AlterColumn("dbo.Contacts", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.Contacts", "Family", c => c.Boolean());
            AlterColumn("dbo.Contacts", "Friend", c => c.Boolean());
            AlterColumn("dbo.Contacts", "Colleague", c => c.Boolean());
            AlterColumn("dbo.Contacts", "Associate", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Associate", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Contacts", "Colleague", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Contacts", "Friend", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Contacts", "Family", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Contacts", "Birthdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Contacts", "Phone", c => c.Int(nullable: false));
        }
    }
}
