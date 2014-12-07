namespace FITBiD_empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EvidencijaIspitnogMaterijalas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumIzdavanjaMaterijala = c.DateTime(nullable: false),
                        IspitniMaterijalId = c.Int(nullable: false),
                        RadnikId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IspitniMaterijals", t => t.IspitniMaterijalId, cascadeDelete: true)
                .ForeignKey("dbo.Radniks", t => t.RadnikId, cascadeDelete: true)
                .Index(t => t.IspitniMaterijalId)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.IspitniMaterijals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Radniks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvidencijaIzvjestajas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumEvidencije = c.DateTime(nullable: false),
                        MenadzmentId = c.Int(nullable: false),
                        IzvjestajId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Izvjestajs", t => t.IzvjestajId, cascadeDelete: true)
                .ForeignKey("dbo.Menadzments", t => t.MenadzmentId, cascadeDelete: true)
                .Index(t => t.MenadzmentId)
                .Index(t => t.IzvjestajId);
            
            CreateTable(
                "dbo.Izvjestajs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menadzments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvidencijaKljucevas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumPreuzimanja = c.DateTime(nullable: false),
                        DatumVracanja = c.DateTime(nullable: false),
                        NastavnoOsobljeId = c.Int(nullable: false),
                        KljucId = c.Int(nullable: false),
                        RadnikId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kljucs", t => t.KljucId, cascadeDelete: true)
                .ForeignKey("dbo.NastavnoOsobljes", t => t.NastavnoOsobljeId, cascadeDelete: true)
                .ForeignKey("dbo.Radniks", t => t.RadnikId, cascadeDelete: true)
                .Index(t => t.NastavnoOsobljeId)
                .Index(t => t.KljucId)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.Kljucs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Barcode = c.String(),
                        UcionicaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ucionicas", t => t.UcionicaId, cascadeDelete: true)
                .Index(t => t.UcionicaId);
            
            CreateTable(
                "dbo.Ucionicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NastavnoOsobljes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Titula = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvidencijaKnjigaZaIznajmljivanjes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumIzdavanja = c.DateTime(nullable: false),
                        DatumVracanja = c.DateTime(nullable: false),
                        KnjigaId = c.Int(nullable: false),
                        RadnikId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Knjigas", t => t.KnjigaId, cascadeDelete: true)
                .ForeignKey("dbo.Radniks", t => t.RadnikId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.KnjigaId)
                .Index(t => t.RadnikId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Knjigas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        GodinaObjavljivanja = c.DateTime(nullable: false),
                        Autor = c.String(),
                        Barcode = c.String(),
                        OznakaStalaze = c.String(),
                        ZaProdaju = c.Boolean(nullable: false),
                        Cijena = c.Double(nullable: false),
                        KnjigaKategorija_KnjigaId = c.Int(),
                        KnjigaKategorija_KategorijaKnjigeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KnjigaKategorijas", t => new { t.KnjigaKategorija_KnjigaId, t.KnjigaKategorija_KategorijaKnjigeId })
                .Index(t => new { t.KnjigaKategorija_KnjigaId, t.KnjigaKategorija_KategorijaKnjigeId });
            
            CreateTable(
                "dbo.KnjigaKategorijas",
                c => new
                    {
                        KnjigaId = c.Int(nullable: false),
                        KategorijaKnjigeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KnjigaId, t.KategorijaKnjigeId })
                .ForeignKey("dbo.KategorijaKnjiges", t => t.KnjigaId, cascadeDelete: true)
                .ForeignKey("dbo.KategorijaKnjiges", t => t.KategorijaKnjigeId, cascadeDelete: true)
                .ForeignKey("dbo.Knjigas", t => t.KnjigaId, cascadeDelete: true)
                .ForeignKey("dbo.Knjigas", t => t.KategorijaKnjigeId, cascadeDelete: true)
                .Index(t => t.KnjigaId)
                .Index(t => t.KategorijaKnjigeId);
            
            CreateTable(
                "dbo.KategorijaKnjiges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        KnjigaKategorija_KnjigaId = c.Int(),
                        KnjigaKategorija_KategorijaKnjigeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KnjigaKategorijas", t => new { t.KnjigaKategorija_KnjigaId, t.KnjigaKategorija_KategorijaKnjigeId })
                .Index(t => new { t.KnjigaKategorija_KnjigaId, t.KnjigaKategorija_KategorijaKnjigeId });
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrojIndeksa = c.String(),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Email = c.String(),
                        Kontakt = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvidencijaKnjigaZaProdajus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumEvidencije = c.DateTime(nullable: false),
                        KnjigaId = c.Int(nullable: false),
                        RadnikId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Knjigas", t => t.KnjigaId, cascadeDelete: true)
                .ForeignKey("dbo.Radniks", t => t.RadnikId, cascadeDelete: true)
                .Index(t => t.KnjigaId)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.EvidencijaNarudzbeIspitnogMaterijalas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kolicina = c.Int(nullable: false),
                        DatumNarudzbe = c.DateTime(nullable: false),
                        IspitniMaterijalId = c.Int(nullable: false),
                        RadnikId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IspitniMaterijals", t => t.IspitniMaterijalId, cascadeDelete: true)
                .ForeignKey("dbo.Radniks", t => t.RadnikId, cascadeDelete: true)
                .Index(t => t.IspitniMaterijalId)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.EvidencijaNotifikacijas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumNotifikacije = c.DateTime(nullable: false),
                        NotifikacijaId = c.Int(nullable: false),
                        RadnikId = c.Int(nullable: false),
                        PredlozakMailaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Notifikacijas", t => t.NotifikacijaId, cascadeDelete: true)
                .ForeignKey("dbo.PredlozakMailas", t => t.PredlozakMailaId, cascadeDelete: true)
                .ForeignKey("dbo.Radniks", t => t.RadnikId, cascadeDelete: true)
                .Index(t => t.NotifikacijaId)
                .Index(t => t.RadnikId)
                .Index(t => t.PredlozakMailaId);
            
            CreateTable(
                "dbo.Notifikacijas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextNotifikacije = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PredlozakMailas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextPredloska = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvidencijaPrijavas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kolicina = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        RadnikId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Radniks", t => t.RadnikId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.KategorijaObjaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoginEvidencijas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumLogina = c.DateTime(nullable: false),
                        RadnikId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        MenadzmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menadzments", t => t.MenadzmentId, cascadeDelete: true)
                .ForeignKey("dbo.Radniks", t => t.RadnikId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.RadnikId)
                .Index(t => t.StudentId)
                .Index(t => t.MenadzmentId);
            
            CreateTable(
                "dbo.Objavas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sadrzaj = c.String(),
                        StudentId = c.Int(nullable: false),
                        KategorijaObjaveId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KategorijaObjaves", t => t.KategorijaObjaveId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.KategorijaObjaveId);
            
            CreateTable(
                "dbo.Rezervacijas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumRezervacije = c.DateTime(nullable: false),
                        RezervacijaPotvrdjena = c.Boolean(nullable: false),
                        KnjigaId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Knjigas", t => t.KnjigaId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.KnjigaId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervacijas", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Rezervacijas", "KnjigaId", "dbo.Knjigas");
            DropForeignKey("dbo.Objavas", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Objavas", "KategorijaObjaveId", "dbo.KategorijaObjaves");
            DropForeignKey("dbo.LoginEvidencijas", "StudentId", "dbo.Students");
            DropForeignKey("dbo.LoginEvidencijas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.LoginEvidencijas", "MenadzmentId", "dbo.Menadzments");
            DropForeignKey("dbo.EvidencijaPrijavas", "StudentId", "dbo.Students");
            DropForeignKey("dbo.EvidencijaPrijavas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.EvidencijaNotifikacijas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.EvidencijaNotifikacijas", "PredlozakMailaId", "dbo.PredlozakMailas");
            DropForeignKey("dbo.EvidencijaNotifikacijas", "NotifikacijaId", "dbo.Notifikacijas");
            DropForeignKey("dbo.EvidencijaNarudzbeIspitnogMaterijalas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.EvidencijaNarudzbeIspitnogMaterijalas", "IspitniMaterijalId", "dbo.IspitniMaterijals");
            DropForeignKey("dbo.EvidencijaKnjigaZaProdajus", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.EvidencijaKnjigaZaProdajus", "KnjigaId", "dbo.Knjigas");
            DropForeignKey("dbo.EvidencijaKnjigaZaIznajmljivanjes", "StudentId", "dbo.Students");
            DropForeignKey("dbo.EvidencijaKnjigaZaIznajmljivanjes", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.EvidencijaKnjigaZaIznajmljivanjes", "KnjigaId", "dbo.Knjigas");
            DropForeignKey("dbo.KnjigaKategorijas", "KategorijaKnjigeId", "dbo.Knjigas");
            DropForeignKey("dbo.Knjigas", new[] { "KnjigaKategorija_KnjigaId", "KnjigaKategorija_KategorijaKnjigeId" }, "dbo.KnjigaKategorijas");
            DropForeignKey("dbo.KnjigaKategorijas", "KnjigaId", "dbo.Knjigas");
            DropForeignKey("dbo.KategorijaKnjiges", new[] { "KnjigaKategorija_KnjigaId", "KnjigaKategorija_KategorijaKnjigeId" }, "dbo.KnjigaKategorijas");
            DropForeignKey("dbo.KnjigaKategorijas", "KategorijaKnjigeId", "dbo.KategorijaKnjiges");
            DropForeignKey("dbo.KnjigaKategorijas", "KnjigaId", "dbo.KategorijaKnjiges");
            DropForeignKey("dbo.EvidencijaKljucevas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.EvidencijaKljucevas", "NastavnoOsobljeId", "dbo.NastavnoOsobljes");
            DropForeignKey("dbo.EvidencijaKljucevas", "KljucId", "dbo.Kljucs");
            DropForeignKey("dbo.Kljucs", "UcionicaId", "dbo.Ucionicas");
            DropForeignKey("dbo.EvidencijaIzvjestajas", "MenadzmentId", "dbo.Menadzments");
            DropForeignKey("dbo.EvidencijaIzvjestajas", "IzvjestajId", "dbo.Izvjestajs");
            DropForeignKey("dbo.EvidencijaIspitnogMaterijalas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.EvidencijaIspitnogMaterijalas", "IspitniMaterijalId", "dbo.IspitniMaterijals");
            DropIndex("dbo.Rezervacijas", new[] { "StudentId" });
            DropIndex("dbo.Rezervacijas", new[] { "KnjigaId" });
            DropIndex("dbo.Objavas", new[] { "KategorijaObjaveId" });
            DropIndex("dbo.Objavas", new[] { "StudentId" });
            DropIndex("dbo.LoginEvidencijas", new[] { "MenadzmentId" });
            DropIndex("dbo.LoginEvidencijas", new[] { "StudentId" });
            DropIndex("dbo.LoginEvidencijas", new[] { "RadnikId" });
            DropIndex("dbo.EvidencijaPrijavas", new[] { "RadnikId" });
            DropIndex("dbo.EvidencijaPrijavas", new[] { "StudentId" });
            DropIndex("dbo.EvidencijaNotifikacijas", new[] { "PredlozakMailaId" });
            DropIndex("dbo.EvidencijaNotifikacijas", new[] { "RadnikId" });
            DropIndex("dbo.EvidencijaNotifikacijas", new[] { "NotifikacijaId" });
            DropIndex("dbo.EvidencijaNarudzbeIspitnogMaterijalas", new[] { "RadnikId" });
            DropIndex("dbo.EvidencijaNarudzbeIspitnogMaterijalas", new[] { "IspitniMaterijalId" });
            DropIndex("dbo.EvidencijaKnjigaZaProdajus", new[] { "RadnikId" });
            DropIndex("dbo.EvidencijaKnjigaZaProdajus", new[] { "KnjigaId" });
            DropIndex("dbo.KategorijaKnjiges", new[] { "KnjigaKategorija_KnjigaId", "KnjigaKategorija_KategorijaKnjigeId" });
            DropIndex("dbo.KnjigaKategorijas", new[] { "KategorijaKnjigeId" });
            DropIndex("dbo.KnjigaKategorijas", new[] { "KnjigaId" });
            DropIndex("dbo.Knjigas", new[] { "KnjigaKategorija_KnjigaId", "KnjigaKategorija_KategorijaKnjigeId" });
            DropIndex("dbo.EvidencijaKnjigaZaIznajmljivanjes", new[] { "StudentId" });
            DropIndex("dbo.EvidencijaKnjigaZaIznajmljivanjes", new[] { "RadnikId" });
            DropIndex("dbo.EvidencijaKnjigaZaIznajmljivanjes", new[] { "KnjigaId" });
            DropIndex("dbo.Kljucs", new[] { "UcionicaId" });
            DropIndex("dbo.EvidencijaKljucevas", new[] { "RadnikId" });
            DropIndex("dbo.EvidencijaKljucevas", new[] { "KljucId" });
            DropIndex("dbo.EvidencijaKljucevas", new[] { "NastavnoOsobljeId" });
            DropIndex("dbo.EvidencijaIzvjestajas", new[] { "IzvjestajId" });
            DropIndex("dbo.EvidencijaIzvjestajas", new[] { "MenadzmentId" });
            DropIndex("dbo.EvidencijaIspitnogMaterijalas", new[] { "RadnikId" });
            DropIndex("dbo.EvidencijaIspitnogMaterijalas", new[] { "IspitniMaterijalId" });
            DropTable("dbo.Rezervacijas");
            DropTable("dbo.Objavas");
            DropTable("dbo.LoginEvidencijas");
            DropTable("dbo.KategorijaObjaves");
            DropTable("dbo.EvidencijaPrijavas");
            DropTable("dbo.PredlozakMailas");
            DropTable("dbo.Notifikacijas");
            DropTable("dbo.EvidencijaNotifikacijas");
            DropTable("dbo.EvidencijaNarudzbeIspitnogMaterijalas");
            DropTable("dbo.EvidencijaKnjigaZaProdajus");
            DropTable("dbo.Students");
            DropTable("dbo.KategorijaKnjiges");
            DropTable("dbo.KnjigaKategorijas");
            DropTable("dbo.Knjigas");
            DropTable("dbo.EvidencijaKnjigaZaIznajmljivanjes");
            DropTable("dbo.NastavnoOsobljes");
            DropTable("dbo.Ucionicas");
            DropTable("dbo.Kljucs");
            DropTable("dbo.EvidencijaKljucevas");
            DropTable("dbo.Menadzments");
            DropTable("dbo.Izvjestajs");
            DropTable("dbo.EvidencijaIzvjestajas");
            DropTable("dbo.Radniks");
            DropTable("dbo.IspitniMaterijals");
            DropTable("dbo.EvidencijaIspitnogMaterijalas");
        }
    }
}
