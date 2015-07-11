using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using FITBiD_empty.Helper;
using FITBiD_empty.ViewModels;

namespace FITBiD_empty.Controllers
{
    public class MenadzmentController : Controller
    {
        private MojContext db = new MojContext();

        public ActionResult Index()
        {
            return View(db.Menadzment.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ime,Prezime,Email,Username,Password")] Menadzment menadzment)
        {
            if (ModelState.IsValid)
            {
                db.Menadzment.Add(menadzment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menadzment);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menadzment menadzment = db.Menadzment.Find(id);
            if (menadzment == null)
            {
                return HttpNotFound();
            }
            return View(menadzment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ime,Prezime,Email,Username,Password")] Menadzment menadzment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menadzment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menadzment);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menadzment menadzment = db.Menadzment.Find(id);
            if (menadzment == null)
            {
                return HttpNotFound();
            }
            return View(menadzment);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Menadzment menadzment = db.Menadzment.Find(id);
            db.Menadzment.Remove(menadzment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

		[Autorizacija("menadzment")]
		public ActionResult MenadzmentBoard() {
			int menadzmentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;

			MenadzmentBoardViewModel Model = new MenadzmentBoardViewModel();
			Model.aktivniStudenti = db.Student.ToList();
			Model.aktivniRadnici = db.Radnik.ToList();

			Model.evidencijaLogina = db.LoginEvidencija
					.Include(x=>x.Radnik)
					.Include(x=>x.Student)
					.Include(x=>x.Menadzment).ToList();

			//Model.iznajmljeneKnjige = ctx.EvidencijaKnjigaZaIznajmljivanje
			//		.Where(x => x.StudentId == studentId)
			//		.Include(x => x.Knjiga)
			//		.ToList();

			//Model.rezervisaneKnjige = ctx.Rezervacija
			//	.Where(x => x.StudentId == studentId)
			//	.Include(x => x.Knjiga)
			//	.ToList();

			//Model.kategorijeObjave = ctx.KategorijaObjave.ToList();

			return View(Model);
		}



    }
}
