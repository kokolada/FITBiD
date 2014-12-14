using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class ExamAccessoriesRecordController : Controller
    {
        // GET: ExamAccessoriesRecord
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExamAccessoriesRecord/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamAccessoriesRecord/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamAccessoriesRecord/Create
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

        // GET: ExamAccessoriesRecord/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamAccessoriesRecord/Edit/5
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

        // GET: ExamAccessoriesRecord/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamAccessoriesRecord/Delete/5
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
