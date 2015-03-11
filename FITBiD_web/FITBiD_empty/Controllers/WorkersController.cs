using FITBiD_empty.DAL;
using FITBiD_empty.Helper;
using FITBiD_empty.Models;
using FITBiD_empty.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FITBiD_empty.Controllers
{
	[Autorizacija("radnik")]
	public class WorkersController : Controller
	{
		MojContext ctx = new MojContext();
		public ActionResult Index()
		{
			WorkersViewModel Model = new WorkersViewModel();

            Model.listaEvidencijaKljuceva = ctx.EvidencijaKljuceva
                .Select(x => new WorkersViewModel.EvidencijaKljucevaInfo()
                {
                    Id = x.Id,
                    NazivUcionice = x.Kljuc.Ucionica.Naziv,
                    NastavnoOsoblje = x.NastavnoOsoblje.Ime + " " + x.NastavnoOsoblje.Prezime,
                    BarKodKljuca = x.Kljuc.Barcode,
                    DatumPreuzimanja = x.DatumPreuzimanja,
                    DatumVracanja = x.DatumVracanja
                }).Where(y => y.DatumVracanja == null).ToList();
			//.Where(y => y.DatumVracanja == null && y.DatumPreuzimanja.Day == DateTime.Today.Day).ToList();

			Model.listaEvidencijaKnjigaZaIznajmljivanje = ctx.EvidencijaKnjigaZaIznajmljivanje
				.Select(x=> new WorkersViewModel.EvidencijaKnjigaZaIznajmljivanjeInfo(){
					Id = x.Id,
					NazivKnjige = x.Knjiga.Naziv,
					Autor = x.Knjiga.Autor,
					DatumIzdavanja = x.DatumIzdavanja,
					DatumVracanja = x.DatumVracanja,
					Student = x.Student.Ime + " " + x.Student.Prezime,
					Vracena = x.Vracena
				}).Where(y=>y.Vracena == false).ToList();
			
			Model.listaEvidencijaKnjigaZaProdaju = ctx.EvidencijaKnjigaZaProdaju
				.Select(x=> new WorkersViewModel.EvidencijaKnjigaZaProdajuInfo(){
					DatumEvidencije = x.DatumEvidencije,
					NazivKnjge = x.Knjiga.Naziv,
					Autor = x.Knjiga.Autor
				}).ToList();

			Model.listaEvidencijaMaterijala = ctx.EvidencijaNarudzbeIspitnogMaterijala
				.Select(x => new WorkersViewModel.EvidencijaNarudzbeIspitnogMaterijalaInfo() {
					NazivMaterijala = x.IspitniMaterijal.Naziv,
					Kolicina = x.Kolicina,
					DatumNarudzbe = x.DatumNarudzbe
				}).ToList();

            Model.listaRezervisanihKnjiga = ctx.Rezervacija
                .Select(x => new WorkersViewModel.RezervacijeKnjigaInfo()
                {
                    Id = x.Id,
                    knjigaId = x.KnjigaId,
                    studentId = x.StudentId,
                    BrojIndexa = x.Student.BrojIndeksa,
                    Naziv = x.Knjiga.Naziv,
                    DatumRezervacije = x.DatumRezervacije,
                    Status = x.RezervacijaPotvrdjena
                }).Where(x => x.Status==false).ToList();

			return View(Model);
		}

		public ActionResult Details(int id)
		{
			return View();
		}

		public ActionResult Create()
		{
			return View();
		}
		public ActionResult CreateIspitniMaterijal()
		{
			IspitniMaterijalViewModel Model = new IspitniMaterijalViewModel();
			Model.IspitniMaterijal = ctx.IspitniMaterijal.ToList();

			return View(Model);
		}
		[HttpPost]
		public ActionResult CreateIspitniMaterijal(int materijal, int kolicina)
		{
			EvidencijaNarudzbeIspitnogMaterijala evIM = new EvidencijaNarudzbeIspitnogMaterijala();
			evIM.DatumNarudzbe = DateTime.Now;
			evIM.IspitniMaterijalId = materijal;
			evIM.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
			evIM.Kolicina = kolicina;

			ctx.EvidencijaNarudzbeIspitnogMaterijala.Add(evIM);
			ctx.SaveChanges();

			return RedirectToAction("Index");
		}

		public ActionResult Edit(int id)
		{
			return View();
		}

		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		public ActionResult Delete(int id)
		{
			return View();
		}

		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
		public ActionResult VracenaKnjiga(int id) {
			EvidencijaKnjigaZaIznajmljivanje evidencija = ctx.EvidencijaKnjigaZaIznajmljivanje.Find(id);
			evidencija.Vracena = true;
			ctx.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult VracenKljuc(int id){
			EvidencijaKljuceva evidencija = ctx.EvidencijaKljuceva.Find(id);
			evidencija.DatumVracanja = DateTime.Today;
			ctx.SaveChanges();
			return RedirectToAction("Index");
		}
        public ActionResult OdobriRezervaciju(int id) {
            Rezervacija r = ctx.Rezervacija.Find(id);
            if (r != null)
            {
                r.RezervacijaPotvrdjena = true;
                ctx.SaveChanges();
                ViewData["RezervacijaPotvrdjena"] = "Uspješno ste odobrili rezervaciju!";
            }
            else
                ViewData["RezervacijaNijePotvrdjena"] = "Došlo je do greške pri odobravanju rezervacije";
            
            return RedirectToAction("Index");
        }



	}
}
