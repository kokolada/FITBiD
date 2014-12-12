using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class ProfileController : Controller
    {
        MojContext ctx = new MojContext();
        public ActionResult View(int studentId)
        {
			Student Model = ctx.Student.Find(studentId);
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
				s.Password =student.Password;	
				ctx.SaveChanges();

			return RedirectToAction("Index","Home");
		}
    }
}