using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using FITBiD_empty.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
			if (studentId != null) {
				Model = ctx.Student.Find(studentId);
			}
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

        public ActionResult StudentBoard(int studentId)
        {
            
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

            return View(Model);
        }

	}
}