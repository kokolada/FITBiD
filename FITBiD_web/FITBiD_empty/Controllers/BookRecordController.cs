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
	public class BookRecordController : Controller
	{
		MojContext ctx = new MojContext();
		
		public ActionResult Index()
		{
			BooksRecordViewModel Model = new BooksRecordViewModel();
			Model.listaEvidencijaKnjigaZaIznajmljivanje = ctx.EvidencijaKnjigaZaIznajmljivanje
			.Select(x => new BooksRecordViewModel.BooksRecordInfo() {
				Id = x.Id,
				NazivKnjige = x.Knjiga.Naziv,
				Autor = x.Knjiga.Autor,
				DatumIzdavanja = x.DatumIzdavanja,
				DatumVracanja = x.DatumVracanja,
				Student = x.Student.Ime + " " + x.Student.Prezime,
				Vracena = x.Vracena
			}).OrderByDescending(x=>x.DatumIzdavanja).ToList();
			return View(Model);
		}

		public ActionResult Details(int id)
		{
			EvidencijaKnjigaZaIznajmljivanje Model = ctx.EvidencijaKnjigaZaIznajmljivanje.Find(id);
            Model.Knjiga = ctx.Knjiga.Find(Model.KnjigaId);
            Model.Student = ctx.Student.Find(Model.StudentId);
            Model.Radnik = ctx.Radnik.Find(Model.RadnikId);
			return View(Model);
		}
		
		public ActionResult Create()
		{
			BooksRecordCreateViewModel Model = new BooksRecordCreateViewModel();
			Model.Knjige = ctx.Knjiga.ToList();
			Model.Studenti = ctx.Student.ToList();

			return View(Model);
		}

		public ActionResult Edit(int id)
		{
			EvidencijaKnjigaZaIznajmljivanje Model = ctx.EvidencijaKnjigaZaIznajmljivanje.Find(id);
            Model.Knjiga = ctx.Knjiga.Find(Model.KnjigaId);
            Model.Student = ctx.Student.Find(Model.StudentId);
            Model.Radnik = ctx.Radnik.Find(Model.RadnikId);
            
			return View(Model);
		}

		public ActionResult Delete(int id)
		{
			EvidencijaKnjigaZaIznajmljivanje evidencija = ctx.EvidencijaKnjigaZaIznajmljivanje.Find(id);
			ctx.EvidencijaKnjigaZaIznajmljivanje.Remove(evidencija);
			ctx.SaveChanges();

			return RedirectToAction("Index");
		}

		public ActionResult Save(string knjiges, string students)
		{
            Knjiga k = ctx.Knjiga.Where(x => x.Barcode == knjiges ).FirstOrDefault();
            Student s = ctx.Student.Where(x => x.BrojIndeksa == students).FirstOrDefault();

			EvidencijaKnjigaZaIznajmljivanje evIZ = new EvidencijaKnjigaZaIznajmljivanje();
			evIZ.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
			evIZ.KnjigaId = k.Id;
			evIZ.StudentId = s.Id;
			evIZ.DatumIzdavanja = DateTime.Now;
			evIZ.DatumVracanja = DateTime.Now.AddMonths(1);
			ctx.EvidencijaKnjigaZaIznajmljivanje.Add(evIZ);
			ctx.SaveChanges();

			return RedirectToAction("Index", "BookRecord");
		}

        public ActionResult BookSearch(string term)
        {
            List<string> knjige =  ctx.Knjiga.Select(x => x.Barcode).ToList();
            // Get Tags from database
            string[] tags = new string[knjige.Count];

            for (int i = 0; i < knjige.Count; i++)
            {
                tags[i] = knjige[i];

            }
            
            return this.Json(tags.Where(t => t.StartsWith(term)),
                            JsonRequestBehavior.AllowGet);
        }

        public ActionResult StudentSearch(string term)
        {
            List<string> studenti = ctx.Student.Select(x => x.BrojIndeksa).ToList();
            // Get Tags from database
            string[] tags = new string[studenti.Count];

            for (int i = 0; i < studenti.Count; i++)
            {
                tags[i] = studenti[i];

            }

            return this.Json(tags.Where(t => t.StartsWith(term)),
                            JsonRequestBehavior.AllowGet);
        }
	}
}
