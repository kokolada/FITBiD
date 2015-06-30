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

namespace FITBiD_empty.Controllers
{
    public class UserActivityController : Controller
    {
        MojContext ctx = new MojContext();
        public ActionResult Index()
        {
			

			return View();
        }

        public ActionResult Details(string students)
        {

            Student s = ctx.Student.Where(x => x.BrojIndeksa == students).FirstOrDefault();
            UserActivityViewModel Model = new UserActivityViewModel();

            ViewData["Greska"] = null;

            if (s != null)
            {
                int studentId = s.Id;

                if (!ModelState.IsValid)
                {
                    Model.listaStudenata = ctx.Student.ToList();
                    return View(Model);
                }
                else
                {
                    Model.praceniStudent = s;

                    Model.objave = ctx.Objava.Where(x => x.StudentId == s.Id)
                        .Include(x => x.Student)
                        .Include(x => x.KategorijaObjave)
                        .ToList();

                    Model.iznajmljeneKnjige = ctx.EvidencijaKnjigaZaIznajmljivanje
                            .Where(x => x.StudentId == s.Id)
                            .Include(x => x.Knjiga)
                            .ToList();

                    Model.rezervisaneKnjige = ctx.Rezervacija
                        .Where(x => x.StudentId == s.Id)
                        .Include(x => x.Knjiga)
                        .ToList();

                    Model.kategorijaObjave = ctx.KategorijaObjave.ToList();

                    Model.prijave = ctx.EvidencijaPrijava.Where(x => x.StudentId == s.Id).Include(x => x.Radnik).ToList();
                }
                return View(Model);
            }
            else
                ViewData["Greska"] = "Traženi student ne postoji u bazi!";
            return null;
            
        }

        // GET: UserActivity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserActivity/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserActivity/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserActivity/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserActivity/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserActivity/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
