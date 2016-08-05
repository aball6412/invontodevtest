namespace InvontoDevTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPhoneTypeIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Phone", c => c.Int());
        }
    }
}
