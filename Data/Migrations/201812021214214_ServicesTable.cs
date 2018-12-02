namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServicesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountServices",
                c => new
                    {
                        AccountServiceId = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountServiceId)
                .ForeignKey("dbo.Accounts", t => t.AccountId)
                .ForeignKey("dbo.Services", t => t.ServiceId)
                .Index(t => t.AccountId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.AccountServices", "AccountId", "dbo.Accounts");
            DropIndex("dbo.AccountServices", new[] { "ServiceId" });
            DropIndex("dbo.AccountServices", new[] { "AccountId" });
            DropTable("dbo.Services");
            DropTable("dbo.AccountServices");
        }
    }
}
