namespace CarteleriaDigital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambios : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FuenteRsses", "RssUrl_RssUrlId", "dbo.RssUrls");
            DropIndex("dbo.FuenteRsses", new[] { "RssUrl_RssUrlId" });
            DropTable("dbo.FuenteRsses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FuenteRsses",
                c => new
                    {
                        FuenteRssId = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Descripcion = c.String(),
                        RssUrl_RssUrlId = c.Int(),
                    })
                .PrimaryKey(t => t.FuenteRssId);
            
            CreateIndex("dbo.FuenteRsses", "RssUrl_RssUrlId");
            AddForeignKey("dbo.FuenteRsses", "RssUrl_RssUrlId", "dbo.RssUrls", "RssUrlId");
        }
    }
}
