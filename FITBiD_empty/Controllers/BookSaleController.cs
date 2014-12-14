using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class BookSaleController : Controller
    {
        MojContext ctx = new MojContext();
        // GET: BookSale
        public ActionResult Index()
        {
            List<EvidencijaKnjigaZaProdaju> Model = ctx.EvidencijaKnjigaZaProdaju.ToList();
            return View(Model);
        }

        // GET: BookSale/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookSale/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookSale/Create
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

        // GET: BookSale/Edit/5
        public ActionResult Edit(int id)
        {
            EvidencijaKnjigaZaProdaju Model = ctx.EvidencijaKnjigaZaProdaju.Find(id);
            return View(Model);
        }

        // POST: BookSale/Edit/5
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

        // GET: BookSale/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookSale/Delete/5
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
