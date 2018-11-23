namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Acc_Comp_SearchCount_Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CardImage = c.String(),
                        ProfessionTitle = c.String(),
                        Phone = c.String(),
                        Location = c.String(),
                        CompanyId = c.Int(),
                        Status = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        AboutUs = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        Fax = c.String(),
                        Email = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.SearchCounts",
                c => new
                    {
                        SearchCountId = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        SearchById = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SearchCountId)
                .ForeignKey("dbo.Accounts", t => t.AccountId)
                .ForeignKey("dbo.Accounts", t => t.SearchById)
                .Index(t => t.AccountId)
                .Index(t => t.SearchById);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SearchCounts", "SearchById", "dbo.Accounts");
            DropForeignKey("dbo.SearchCounts", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "CompanyId", "dbo.Companies");
            DropIndex("dbo.SearchCounts", new[] { "SearchById" });
            DropIndex("dbo.SearchCounts", new[] { "AccountId" });
            DropIndex("dbo.Accounts", new[] { "CompanyId" });
            DropTable("dbo.SearchCounts");
            DropTable("dbo.Companies");
            DropTable("dbo.Accounts");
        }
    }
}
