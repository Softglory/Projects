namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class missingAccountFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "FacebookUrl", c => c.String());
            AddColumn("dbo.Accounts", "TwitterUrl", c => c.String());
            AddColumn("dbo.Accounts", "Website", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Website");
            DropColumn("dbo.Accounts", "TwitterUrl");
            DropColumn("dbo.Accounts", "FacebookUrl");
        }
    }
}
