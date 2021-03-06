﻿using FITBiD_empty.DAL;
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
			Student s = ctx.Student.Find(student.Id);
			s.Ime = student.Ime;
			s.Prezime = student.Prezime;
			s.BrojIndeksa = student.BrojIndeksa;
			s.Email = student.Email;
			s.Kontakt = student.Kontakt;
			s.Password = student.Password;
			ctx.SaveChanges();

			if (Autentifikacija.GetLogiraniKorisnik(HttpContext).rola == "student")
				return RedirectToAction("StudentBoard","Profile");
			if(Autentifikacija.GetLogiraniKorisnik(HttpContext).rola == "menadzment")
				return RedirectToAction("MenadzmentBoard","Menadzment");
			return View("Index","Profile");
				
		}

        [Autorizacija("student")]
        public ActionResult StudentBoard()
        {
            int studentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;

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
			if (!ModelState.IsValid || sadrzajTetxarea == "") {
				
				return RedirectToAction("StudentBoard");

			}
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
                .OrderByDescending(x => x.Id)
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

       
        public ActionResult Pretraga(string poruka = "", List<Knjiga> Model = null)
	    {
            if (Model == null)
            {
                Model = ctx.Knjiga.ToList();
            }
            if (poruka != "")
            {
                ViewData["Rezervacija"] = poruka;
            }
            ViewData["Kategorije"] = ctx.KategorijaKnjige.ToList();

            return View(Model);
	    }

        [HttpPost]
        public ActionResult Pretraga(string nazivKnjige, int izabranaKategorija = -1)
        {
            List<Knjiga> Model = new List<Knjiga>();
            if (nazivKnjige != "") { 
                 Model = ctx.Knjiga
                            .Where(x=>x.Naziv==nazivKnjige)
                            .ToList();
            }
            if(izabranaKategorija>-1)
            {
                List<KnjigaKategorija> listaKnjiga = ctx.KnjigaKategorija.Where(x => x.KategorijaKnjigeId == izabranaKategorija).ToList();
                foreach (KnjigaKategorija x in listaKnjiga)
                {
                    Model.Add(ctx.Knjiga.Find(x.KnjigaId));
                }
            }

            if (Model.Count == 0)
            {
                Model = ctx.Knjiga.ToList();
                ViewData["Greska"] = "Nema rezultata pretage !";
            }

            ViewData["Kategorije"] = ctx.KategorijaKnjige.ToList();

            return View(Model);
        }
		[Autorizacija("menadzment")]
		public ActionResult Delete(int id) {
			Student s = ctx.Student.Find(id);
			ctx.Student.Remove(s);
			ctx.SaveChanges();
			return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());
		}
	}
}