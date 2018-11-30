namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesInAdTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ads", "AdDescription", c => c.String());
            AddColumn("dbo.Ads", "AdType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ads", "AdType");
            DropColumn("dbo.Ads", "AdDescription");
        }
    }
}
