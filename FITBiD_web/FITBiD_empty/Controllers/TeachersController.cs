using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class TeachersController : Controller
    {
        // GET: Teachers
		MojContext ctx = new MojContext();
        public ActionResult Index()
        {
			List<NastavnoOsoblje> nastavno = ctx.NastavnoOsoblje.ToList();
            return View(nastavno);
        }

        // GET: Teachers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Teachers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
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

        // GET: Teachers/Edit/5
        public ActionResult Edit(int id)
        {
			NastavnoOsoblje n = ctx.NastavnoOsoblje.Find(id);
            return View(n);
        }

        // POST: Teachers/Edit/5
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

        // GET: Teachers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Teachers/Delete/5
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
    }
}
