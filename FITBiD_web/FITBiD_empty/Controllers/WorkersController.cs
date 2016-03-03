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
	
	public class WorkersController : Controller
	{
		MojContext ctx = new MojContext();
		[Autorizacija("radnik")]
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
				}).Where(y=>y.Vracena == false).Take(8).ToList();
			
			Model.listaEvidencijaKnjigaZaProdaju = ctx.EvidencijaKnjigaZaProdaju
				.Select(x=> new WorkersViewModel.EvidencijaKnjigaZaProdajuInfo(){
					DatumEvidencije = x.DatumEvidencije,
					NazivKnjge = x.Knjiga.Naziv,
					Autor = x.Knjiga.Autor,
                    Cijena = x.Knjiga.Cijena
				}).OrderByDescending(x => x.DatumEvidencije).Take(8).ToList();

			Model.listaEvidencijaMaterijala = ctx.EvidencijaNarudzbeIspitnogMaterijala
				.Select(x => new WorkersViewModel.EvidencijaNarudzbeIspitnogMaterijalaInfo() {
					NazivMaterijala = x.IspitniMaterijal.Naziv,
					Kolicina = x.Kolicina,
					DatumNarudzbe = x.DatumNarudzbe
				}).OrderByDescending(x => x.DatumNarudzbe).Take(8).ToList();

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
                }).Where(x => x.Status==false).OrderByDescending(x => x.DatumRezervacije).ToList();

			return View(Model);
		}
		[Autorizacija("radnik")]
		public ActionResult Details(int id)
		{
			return View();
		}
		[Autorizacija("radnik")]
		public ActionResult Create()
		{
			return View();
		}
		[Autorizacija("radnik")]
		public ActionResult CreateIspitniMaterijal()
		{
			IspitniMaterijalViewModel Model = new IspitniMaterijalViewModel();
			Model.IspitniMaterijal = ctx.IspitniMaterijal.ToList();

			return View(Model);
		}
		[HttpPost]
		[Autorizacija("radnik")]
		public ActionResult CreateIspitniMaterijal(int materijal, int kolicina)
		{
            if(materijal == -1){
                TempData["MaterijalGreska"] = "Potrebno odabrati materijal";
                return RedirectToAction("CreateIspitniMaterijal", "Workers");
            }
			EvidencijaNarudzbeIspitnogMaterijala evIM = new EvidencijaNarudzbeIspitnogMaterijala();
			evIM.DatumNarudzbe = DateTime.Now;
            evIM.IspitniMaterijalId = materijal;
			evIM.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
			evIM.Kolicina = kolicina;

			ctx.EvidencijaNarudzbeIspitnogMaterijala.Add(evIM);
			ctx.SaveChanges();

			return RedirectToAction("Index");
		}
		public ActionResult Edit(int? id)
		{
			Radnik Model = new Radnik();
			Model = ctx.Radnik.Find(id);

			return View(Model); ;
		}

		[Autorizacija("menadzment")]
		public ActionResult Delete(int id)
		{
			Radnik s = ctx.Radnik.Find(id);
			ctx.Radnik.Remove(s);
			ctx.SaveChanges();
			return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());
		
		}
		[Autorizacija("radnik")]
		public ActionResult VracenaKnjiga(int id) {
			EvidencijaKnjigaZaIznajmljivanje evidencija = ctx.EvidencijaKnjigaZaIznajmljivanje.Find(id);
			evidencija.Vracena = true;
			ctx.SaveChanges();
			return RedirectToAction("Index");
		}
		[Autorizacija("radnik")]
		public ActionResult VracenKljuc(int id){
			EvidencijaKljuceva evidencija = ctx.EvidencijaKljuceva.Find(id);
			evidencija.DatumVracanja = DateTime.Today;
			ctx.SaveChanges();
			return RedirectToAction("Index");
		}
		[Autorizacija("radnik")]
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

		public ActionResult Save(Radnik radnik) {
			Radnik r = ctx.Radnik.Find(radnik.Id);
			r.Ime = radnik.Ime;
			r.Prezime = radnik.Prezime;
			r.Email = radnik.Email;
			r.Username = radnik.Username;
			r.Password = radnik.Password;
			ctx.SaveChanges();

			if (Autentifikacija.GetLogiraniKorisnik(HttpContext).rola == "radnik")
				return RedirectToAction("Index", "Workers");
			if (Autentifikacija.GetLogiraniKorisnik(HttpContext).rola == "menadzment")
				return RedirectToAction("MenadzmentBoard", "Menadzment");
			return View("Index", "Profile");

		}
        public ActionResult WorkerSearch(string term)
        {
            List<string> radnici = ctx.Radnik.Select(x => x.Ime).ToList();
            string[] tags = new string[radnici.Count];

            for (int i = 0; i < radnici.Count; i++)
            {
                tags[i] = radnici[i];

            }

            return this.Json(tags.Where(t => t.StartsWith(term)),
                            JsonRequestBehavior.AllowGet);
        }

	    public ActionResult DetaljiRadnikaMenadzment(string workers)
	    {
            Radnik r = ctx.Radnik.Where(x => x.Ime == workers).FirstOrDefault();
            Korisnik Model = new Korisnik();
	        Model.Id = r.Id;
	        Model.username = r.Username;
	        Model.Ime = r.Ime;
	        Model.Prezime = r.Prezime;
            return View(Model);

	    }

	}
}
