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
    public class EntryRecordController : Controller
    {
        MojContext ctx = new MojContext();
        public ActionResult Index()
        {
			EntryRecordViewModel Model = new EntryRecordViewModel();
			Model.listaEvidencija = ctx.EvidencijaPrijava.Select(x=> new EntryRecordViewModel.EvidencijaInfo{
				Id = x.Id,
				studentId = x.StudentId,
				studentIme = x.Student.Ime,
				studentPrezime = x.Student.Prezime,
				kolicina = x.Kolicina,
				radnikId = x.RadnikId,
				radnikIme = x.Radnik.Ime,
				radnikPrezime = x.Radnik.Prezime,
				brojIndeksa = x.Student.BrojIndeksa
			}).ToList();
			
		
            return View(Model);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
			EntryRecordCreateViewModel erc = new EntryRecordCreateViewModel();
			erc.listaStudenata = ctx.Student.ToList();
            return View("Create",erc);
        }

        [HttpPost]
        public ActionResult Create(int studentId, int kolicina)
        {
			if (!ModelState.IsValid) {
				EntryRecordCreateViewModel erc = new EntryRecordCreateViewModel();
				erc.listaStudenata = ctx.Student.ToList();
				return View("Create", erc);
			}
			else {
				EvidencijaPrijava pr = new EvidencijaPrijava();
				pr.Kolicina = kolicina;
				pr.StudentId = studentId;
				pr.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;

				ctx.EvidencijaPrijava.Add(pr);
				ctx.SaveChanges();

			}
			return RedirectToAction("Index");
        }

		public ActionResult Edit(int id) {

			EvidencijaPrijava ep = new EvidencijaPrijava();
			ep = ctx.EvidencijaPrijava.Find(id);
			return View(ep);

			
		}
		[HttpPost]
		public ActionResult Edit(EvidencijaPrijava evidencija) {
			
			EvidencijaPrijava ep = ctx.EvidencijaPrijava.Find(evidencija.Id);
			ep.Kolicina = evidencija.Kolicina;
		
			ctx.SaveChanges();

			return RedirectToAction("Index", "EntryRecord");
			

		}

        public ActionResult Delete(int id)
        {
           EvidencijaPrijava ep = ctx.EvidencijaPrijava.Find(id);
		   ctx.EvidencijaPrijava.Remove(ep);
		   ctx.SaveChanges();

		   return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());
        }
    }
}
