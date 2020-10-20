namespace CarteleriaDigital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        BannerId = c.Int(nullable: false, identity: true),
                        NombreBanner = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        HoraInicio = c.Time(nullable: false, precision: 7),
                        HoraFin = c.Time(nullable: false, precision: 7),
                        EstrategiaTipoDatosFuente_EstrategiaTipoDatosFuenteId = c.Int(),
                    })
                .PrimaryKey(t => t.BannerId)
                .ForeignKey("dbo.EstrategiaTipoDatosFuentes", t => t.EstrategiaTipoDatosFuente_EstrategiaTipoDatosFuenteId)
                .Index(t => t.EstrategiaTipoDatosFuente_EstrategiaTipoDatosFuenteId);
            
            CreateTable(
                "dbo.EstrategiaTipoDatosFuentes",
                c => new
                    {
                        EstrategiaTipoDatosFuenteId = c.Int(nullable: false, identity: true),
                        NombreTipoDeEstrategia = c.String(),
                        DatosEstrategiaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstrategiaTipoDatosFuenteId);
            
            CreateTable(
                "dbo.Campaña",
                c => new
                    {
                        CampañaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        HoraInicio = c.Time(nullable: false, precision: 7),
                        HoraFin = c.Time(nullable: false, precision: 7),
                        DuracionImagen = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CampañaId);
            
            CreateTable(
                "dbo.Imagens",
                c => new
                    {
                        ImagenId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        RutaImagen = c.String(),
                        Campaña_CampañaId = c.Int(),
                    })
                .PrimaryKey(t => t.ImagenId)
                .ForeignKey("dbo.Campaña", t => t.Campaña_CampañaId)
                .Index(t => t.Campaña_CampañaId);
            
            CreateTable(
                "dbo.FuenteRsses",
                c => new
                    {
                        FuenteRssId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.FuenteRssId);
            
            CreateTable(
                "dbo.TextoFijoes",
                c => new
                    {
                        TextoFijoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.TextoFijoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Imagens", "Campaña_CampañaId", "dbo.Campaña");
            DropForeignKey("dbo.Banners", "EstrategiaTipoDatosFuente_EstrategiaTipoDatosFuenteId", "dbo.EstrategiaTipoDatosFuentes");
            DropIndex("dbo.Imagens", new[] { "Campaña_CampañaId" });
            DropIndex("dbo.Banners", new[] { "EstrategiaTipoDatosFuente_EstrategiaTipoDatosFuenteId" });
            DropTable("dbo.TextoFijoes");
            DropTable("dbo.FuenteRsses");
            DropTable("dbo.Imagens");
            DropTable("dbo.Campaña");
            DropTable("dbo.EstrategiaTipoDatosFuentes");
            DropTable("dbo.Banners");
        }
    }
}
