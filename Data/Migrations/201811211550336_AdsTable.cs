namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ads",
                c => new
                    {
                        AdId = c.Int(nullable: false, identity: true),
                        AdImage = c.String(),
                        AdCarrer = c.String(),
                        Status = c.Boolean(nullable: false),
                        AdCountClick = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AdId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ads");
        }
    }
}
