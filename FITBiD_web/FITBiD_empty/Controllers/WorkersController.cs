using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class WorkersController : Controller
    {
        // GET: Workers
		MojContext ctx = new MojContext();
        public ActionResult Index()
        {
			List<Radnik> radnici = ctx.Radnik.ToList();
            return View(radnici);
        }

        // GET: Workers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Workers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workers/Create
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

        // GET: Workers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Workers/Edit/5
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

        // GET: Workers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Workers/Delete/5
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
