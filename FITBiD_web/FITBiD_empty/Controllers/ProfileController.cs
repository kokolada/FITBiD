using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using FITBiD_empty.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FITBiD_empty.Helper;

namespace FITBiD_empty.Controllers {
	public class ProfileController : Controller {
		MojContext ctx = new MojContext();
        
		public ActionResult Index(int studentId) {
			ProfileViewModel Model = new ProfileViewModel();
			Student s = ctx.Student.Find(studentId);
			Model.brojIndeksa = s.BrojIndeksa;
			Model.ime = s.Ime;
			Model.prezime = s.Prezime;
			Model.email = s.Email;
			Model.kontakt = s.Kontakt;
			Model.password=s.Password;

			return View(Model);
		}
		public ActionResult Edit(int studentId) {

			Student Model = new Student();
			Model = ctx.Student.Find(studentId);
		
			return View(Model);
		}
		public ActionResult Save(Student student) {
			int studentID = 1;

			Student s = ctx.Student.Find(studentID);
			s.Ime = student.Ime;
			s.Prezime = student.Prezime;
			s.BrojIndeksa = student.BrojIndeksa;
			s.Email = student.Email;
			s.Kontakt = student.Kontakt;
			s.Password = student.Password;
			ctx.SaveChanges();

			return RedirectToAction("Index", "Home");
		}

        [Autorizacija("student")]
        public ActionResult StudentBoard()
        {
            int studentId = 1;
            //int studentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;

            StudentBoardViewModel Model = new StudentBoardViewModel();

            Model.objave = ctx.Objava
                .Include(x => x.Student)
                .Include(x => x.KategorijaObjave)
                .ToList();

            Model.iznajmljeneKnjige = ctx.EvidencijaKnjigaZaIznajmljivanje
                    .Where(x => x.StudentId == studentId)
                    .Include(x => x.Knjiga)
                    .ToList();

            
            Model.rezervisaneKnjige = ctx.Rezervacija
                .Where(x => x.StudentId == studentId)
                .Include(x => x.Knjiga)
                .ToList();

            Model.kategorijeObjave = ctx.KategorijaObjave.ToList();

            return View(Model);
        }

	    [HttpPost]
        [Autorizacija("student")]
	    public ActionResult StudentBoard(int izabranaKategorijaObjave, string sadrzajTetxarea)
	    {
            Objava o = new Objava();

            o.StudentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
	        o.Sadrzaj = sadrzajTetxarea;
	        o.KategorijaObjaveId = izabranaKategorijaObjave;
	        o.StudentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;

	        ctx.Objava.Add(o);
	        ctx.SaveChanges();

            return RedirectToAction("StudentBoard");
	    }

        [Autorizacija("student")]
	    public ActionResult PitanjeOdgovor(int objavaId)
	    {
            PitanjeOdogovorViewModel Model = new PitanjeOdogovorViewModel();
	        Model.objava = ctx.Objava
                .Where(x => x.Id == objavaId)
                .Include(x => x.Student)
                .Include(x => x.KategorijaObjave)
                .FirstOrDefault();

	        Model.Komentari = ctx.Komentar
                .Where(x => x.ObjavaId == objavaId)
                .Include(x => x.Student)
                .Include(x => x.Objava)
                .ToList();

	        return View(Model);
	    }

        [HttpPost]
        [Autorizacija("student")]
        public ActionResult PitanjeOdgovor(string odgovorTetxarea)
	    {
            Komentar k = new Komentar();
            k.Sadrzaj = odgovorTetxarea;
            k.ObjavaId = int.Parse(Request.QueryString["objavaId"]);
            k.StudentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;

            ctx.Komentar.Add(k);
            ctx.SaveChanges();

            return RedirectToAction("PitanjeOdgovor", new {objavaId=k.ObjavaId});
	    }
	}
}