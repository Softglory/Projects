namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountTableChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "FirstNameEn", c => c.String());
            AddColumn("dbo.Accounts", "LastNameEn", c => c.String());
            AddColumn("dbo.Accounts", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Email");
            DropColumn("dbo.Accounts", "LastNameEn");
            DropColumn("dbo.Accounts", "FirstNameEn");
        }
    }
}
