namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_contactiddegisikliği : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Contacts");
            AddColumn("dbo.Contacts", "ContactID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Contacts", "ContactID");
            DropColumn("dbo.Contacts", "ContentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "ContentID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Contacts");
            DropColumn("dbo.Contacts", "ContactID");
            AddPrimaryKey("dbo.Contacts", "ContentID");
        }
    }
}
