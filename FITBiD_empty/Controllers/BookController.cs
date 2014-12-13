using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class BookController : DAController
    {
        MojContext ctx = new MojContext();
        // GET: Book
        public ActionResult Index(int bookId)
        {
            Knjiga Model = ctx.Knjiga.Find(bookId);
            return View(Model);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            Knjiga Model = new Knjiga();
            return View("Edit", Model);
        }        

        // GET: Book/Edit/5
        public ActionResult Edit(int bookId)
        {
            Knjiga Model = ctx.Knjiga.Find(bookId);
            
            return View(Model);
        }
        
        public ActionResult Save(Knjiga k)
        {
            Knjiga knjiga;
            if (k.Id == 0)
            {
                knjiga = new Knjiga();
                ctx.Knjiga.Add(knjiga);
            }
            else
                knjiga = ctx.Knjiga.Find(k.Id);

            knjiga.GodinaObjavljivanja = k.GodinaObjavljivanja;
            knjiga.Naziv = k.Naziv;
            knjiga.Autor = k.Autor;
            knjiga.Barcode = k.Barcode;
            knjiga.OznakaStalaze = k.OznakaStalaze;
            knjiga.Cijena = k.Cijena;
            knjiga.ZaProdaju = k.ZaProdaju;
                        
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
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

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
