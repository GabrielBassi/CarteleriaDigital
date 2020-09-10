namespace CarteleriaDigital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _432 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Banners", "HoraInicio", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Banners", "HoraFin", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Banners", "HoraFin", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Banners", "HoraInicio", c => c.DateTime(nullable: false));
        }
    }
}
