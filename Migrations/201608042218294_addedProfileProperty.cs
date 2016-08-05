namespace InvontoDevTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedProfileProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "profile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "profile");
        }
    }
}
