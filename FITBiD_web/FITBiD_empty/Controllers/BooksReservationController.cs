using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using FITBiD_empty.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using FITBiD_empty.Helper;

namespace FITBiD_empty.Controllers
{
    public class BooksReservationController : Controller
    {
        MojContext ctx = new MojContext();
        public ActionResult Index()
        {
            BooksReservationViewModel Model = new BooksReservationViewModel();
            Model.rezervacije = ctx.Rezervacija.Select(x => new BooksReservationViewModel.RezervacijaInfo
            {
				Id = x.Id,
                DatumRezervacije = x.DatumRezervacije,
                RezervacijaPotvrdjena = x.RezervacijaPotvrdjena,
                BrojIndeskaStudenta = x.Student.BrojIndeksa,
				ImeStudenta = x.Student.Ime,
				PrezimeStudenta = x.Student.Prezime,
                NazivKnjige = x.Knjiga.Naziv

            }).OrderByDescending(x => x.DatumRezervacije).ToList();

            return View(Model);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
			BooksReservationCreateViewModel rezervacija = new BooksReservationCreateViewModel();
			
			rezervacija.ListaKnjiga = ctx.Knjiga.Select(x=> new SelectListItem {Value = x.Id.ToString(), Text = x.Naziv}).ToList();
			rezervacija.ListaStudenata = ctx.Student.Select(y=> new SelectListItem {Value = y.Id.ToString(), Text = y.BrojIndeksa}).ToList();
			
			return View("Create",rezervacija);
        }

        [HttpPost]
		public ActionResult Create(BooksReservationCreateViewModel rezervacija)
        {
			if (!ModelState.IsValid) {
				rezervacija.ListaKnjiga = ctx.Knjiga.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Naziv }).ToList();
				rezervacija.ListaStudenata = ctx.Student.Select(y => new SelectListItem { Value = y.Id.ToString(), Text = y.BrojIndeksa }).ToList();

				return View("Create", rezervacija);
			}
			else { 
				Rezervacija r = new Rezervacija();
				r.DatumRezervacije = rezervacija.DatumRezervacije;
				r.RezervacijaPotvrdjena = rezervacija.RezervacijaPotvrdjena;
				r.KnjigaId = rezervacija.KnjigaId;
				r.StudentId = rezervacija.StudentId;

				ctx.Rezervacija.Add(r);
				ctx.SaveChanges();
				
			}
			return RedirectToAction("Index");
        }
        
        public ActionResult Rezervisi(int knjigaId)
        {
            Rezervacija r = new Rezervacija();
            r.DatumRezervacije = DateTime.Now;
            r.RezervacijaPotvrdjena = false;
            r.KnjigaId = knjigaId;
            r.StudentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;

            string Poruka =  "Knjiga je uspješno rezervisana. Radnik biblioteke će biti obavješten !";

            ctx.Rezervacija.Add(r);
            ctx.SaveChanges();
            
            return RedirectToAction("Pretraga", "Profile", new {poruka = Poruka});
        }

        public ActionResult Edit(int id)
        {
            Rezervacija r = ctx.Rezervacija.Where(x => x.Id == id).FirstOrDefault();
			BooksReservationEditViewModel Model = new BooksReservationEditViewModel
            {	
			   ListaKnjiga = ctx.Knjiga.Select(x=> new SelectListItem {Value = x.Id.ToString(), Text = x.Naziv }).ToList()
            };
            return View(Model);
        }

        [HttpPost]
		public ActionResult Edit(BooksReservationEditViewModel rezervacija)
        {
			if (!ModelState.IsValid) {
				rezervacija.ListaKnjiga = ctx.Knjiga.Select(x=> new SelectListItem {Value = x.Id.ToString(), Text = x.Naziv }).ToList();
				
				return View("Edit",rezervacija);
			}
			else {
				Rezervacija r = ctx.Rezervacija.Where(x => x.Id == rezervacija.Id).FirstOrDefault();
				r.KnjigaId = rezervacija.KnjigaId;

				ctx.SaveChanges();
				return RedirectToAction("Index");
			}

        }

        public ActionResult Delete(int id)
        {
           Rezervacija r = ctx.Rezervacija.Find(id);
		   ctx.Rezervacija.Remove(r);
		   ctx.SaveChanges();

		   return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());
        }

    }
}
