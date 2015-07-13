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
	public class BookSaleController : Controller
	{
		MojContext ctx = new MojContext();
	   
		public ActionResult Index()
		{
			BookSaleViewModel Model = new BookSaleViewModel();
			Model.listaEvidencijaKnjigaZaProdaju = ctx.EvidencijaKnjigaZaProdaju
			.Select(x => new BookSaleViewModel.BooksSaleInfo() {
				Id = x.Id,
				DatumEvidencije = x.DatumEvidencije,
				NazivKnjge = x.Knjiga.Naziv,
				Radnik = x.Radnik.Ime + " " + x.Radnik.Prezime,
                Cijena = x.Knjiga.Cijena
                
			}).OrderByDescending(x => x.DatumEvidencije).ToList();
			return View(Model);
		}

		public ActionResult Details(int id)
		{
			EvidencijaKnjigaZaProdaju Model = ctx.EvidencijaKnjigaZaProdaju.Find(id);
            Model.Knjiga = ctx.Knjiga.Find(Model.KnjigaId);
            Model.Radnik = ctx.Radnik.Find(Model.RadnikId);
			return View(Model);
		}

		public ActionResult Create()
		{
			EvidencijaProdajeKnjigaViewModel Model = new EvidencijaProdajeKnjigaViewModel();
			Model.Knjige = ctx.Knjiga.Where(x=>x.ZaProdaju).ToList();

			return View(Model);
		}
		[HttpPost]
        public ActionResult Create(string knjiges)
		{
			EvidencijaKnjigaZaProdaju evK = new EvidencijaKnjigaZaProdaju();
            Knjiga k = ctx.Knjiga.Where(x => x.Naziv == knjiges).FirstOrDefault();

            if (k != null)
            {
                evK.DatumEvidencije = DateTime.Now;
                evK.KnjigaId = k.Id;
                evK.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
                ctx.EvidencijaKnjigaZaProdaju.Add(evK);
            }			

			ctx.SaveChanges();

			return RedirectToAction("Index", "BookSale");
		}

		public ActionResult Edit(int id)
		{
			EvidencijaKnjigaZaProdaju Model = ctx.EvidencijaKnjigaZaProdaju.Find(id);
			return View(Model);
		}

		public ActionResult Delete(int id)
		{
			EvidencijaKnjigaZaProdaju evidencija = ctx.EvidencijaKnjigaZaProdaju.Find(id);
			ctx.EvidencijaKnjigaZaProdaju.Remove(evidencija);
			ctx.SaveChanges();

			return RedirectToAction("Index");
		}

		public ActionResult Save(EvidencijaKnjigaZaProdaju evidencija) 
		{
			EvidencijaKnjigaZaProdaju e;
			if (evidencija.Id == 0)
			{
				e = new EvidencijaKnjigaZaProdaju();
				ctx.EvidencijaKnjigaZaProdaju.Add(e);
			}
			else
				e = ctx.EvidencijaKnjigaZaProdaju.Find(evidencija.Id);

			e.Knjiga = evidencija.Knjiga;
			e.KnjigaId = evidencija.KnjigaId;
			e.Radnik = evidencija.Radnik;
			e.RadnikId = evidencija.RadnikId;
			e.DatumEvidencije = evidencija.DatumEvidencije;

			ctx.SaveChanges();

			return RedirectToAction("Index");
		}

        public ActionResult BookSearch(string term)
        {
            List<string> knjige =  ctx.Knjiga.Select(x => x.Naziv).ToList();
            // Get Tags from database
            string[] tags = new string[knjige.Count];

            for (int i = 0; i < knjige.Count; i++)
            {
                tags[i] = knjige[i];

            }
            
            return this.Json(tags.Where(t => t.StartsWith(term)),
                            JsonRequestBehavior.AllowGet);
        }
		
	}
}
