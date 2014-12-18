using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class ExamAccessoriesController : Controller
    {
        // GET: ExamAccessories
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExamAccessories/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamAccessories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamAccessories/Create
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

        // GET: ExamAccessories/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamAccessories/Edit/5
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

        // GET: ExamAccessories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamAccessories/Delete/5
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
