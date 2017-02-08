namespace IZSUFormApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abones",
                c => new
                    {
                        AboneID = c.Int(nullable: false, identity: true),
                        AboneNo = c.Int(nullable: false),
                        AboneAdSoyad = c.String(),
                        AboneTuruID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AboneID)
                .ForeignKey("dbo.AboneTurus", t => t.AboneTuruID, cascadeDelete: true)
                .Index(t => t.AboneTuruID);
            
            CreateTable(
                "dbo.AboneTurus",
                c => new
                    {
                        AboneTuruID = c.Int(nullable: false, identity: true),
                        AboneTuruAd = c.String(),
                    })
                .PrimaryKey(t => t.AboneTuruID);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        FaturaID = c.Int(nullable: false, identity: true),
                        AboneID = c.Int(nullable: false),
                        OdemeTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OncekiSayac = c.Int(nullable: false),
                        GuncelSayac = c.Int(nullable: false),
                        FaturaTarihi = c.DateTime(nullable: false),
                        Tahsilat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FaturaID)
                .ForeignKey("dbo.Abones", t => t.AboneID, cascadeDelete: true)
                .Index(t => t.AboneID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faturas", "AboneID", "dbo.Abones");
            DropForeignKey("dbo.Abones", "AboneTuruID", "dbo.AboneTurus");
            DropIndex("dbo.Faturas", new[] { "AboneID" });
            DropIndex("dbo.Abones", new[] { "AboneTuruID" });
            DropTable("dbo.Faturas");
            DropTable("dbo.AboneTurus");
            DropTable("dbo.Abones");
        }
    }
}
