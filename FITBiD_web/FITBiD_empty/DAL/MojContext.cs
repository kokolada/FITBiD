using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FITBiD_empty.DAL
{
	public class MojContext : DbContext
	{
		public DbSet<EvidencijaIspitnogMaterijala> EvidencijaIspitnogMaterijala { get; set; }
		public DbSet<EvidencijaIzvjestaja> EvidencijaIzvjestaja { get; set; }
		public DbSet<EvidencijaKljuceva> EvidencijaKljuceva { get; set; }
		public DbSet<EvidencijaKnjigaZaIznajmljivanje> EvidencijaKnjigaZaIznajmljivanje { get; set; }
		public DbSet<EvidencijaKnjigaZaProdaju> EvidencijaKnjigaZaProdaju { get; set; }
		public DbSet<EvidencijaNarudzbeIspitnogMaterijala> EvidencijaNarudzbeIspitnogMaterijala { get; set; }
		public DbSet<EvidencijaNotifikacija> EvidencijaNotifikacija { get; set; }
		public DbSet<EvidencijaPrijava> EvidencijaPrijava { get; set; }
		public DbSet<IspitniMaterijal> IspitniMaterijal { get; set; }
		public DbSet<Izvjestaj> Izvjestaj { get; set; }
		public DbSet<KategorijaKnjige> KategorijaKnjige { get; set; }
		public DbSet<KategorijaObjave> KategorijaObjave { get; set; }
		public DbSet<Kljuc> Kljuc { get; set; }
		public DbSet<Knjiga> Knjiga { get; set; }
		public DbSet<KnjigaKategorija> KnjigaKategorija { get; set; }
		public DbSet<LoginEvidencija> LoginEvidencija { get; set; }
		public DbSet<Menadzment> Menadzment { get; set; }
		public DbSet<NastavnoOsoblje> NastavnoOsoblje { get; set; }
		public DbSet<Notifikacija> Notifikacija { get; set; }
		public DbSet<Objava> Objava { get; set; }
		public DbSet<PredlozakMaila> PredlozakMaila { get; set; }
		public DbSet<Radnik> Radnik { get; set; }
		public DbSet<Rezervacija> Rezervacija { get; set; }
		public DbSet<Student> Student { get; set; }
		public DbSet<Ucionica> Ucionica { get; set; }



		public MojContext() : base("Name=MojConnectionString"){}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<KnjigaKategorija>()
				.HasKey(c => new { c.KategorijaKnjigeId, c.KnjigaId });

			modelBuilder.Entity<Knjiga>()
				.HasMany(c => c.KnjigaKategorijas)
				.WithRequired()
				.HasForeignKey(c => c.KnjigaId);

			modelBuilder.Entity<KategorijaKnjige>()
				.HasMany(c => c.KnjigaKategorijas)
				.WithRequired()
				.HasForeignKey(c => c.KategorijaKnjigeId);
		}
	}
}