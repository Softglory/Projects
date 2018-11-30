namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KeywordsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountKeyword",
                c => new
                    {
                        AccountKeywordId = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        KeyWord = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountKeywordId)
                .ForeignKey("dbo.Accounts", t => t.AccountId)
                .Index(t => t.AccountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountKeyword", "AccountId", "dbo.Accounts");
            DropIndex("dbo.AccountKeyword", new[] { "AccountId" });
            DropTable("dbo.AccountKeyword");
        }
    }
}
