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
        
        public ActionResult Index()
        {
            List<Knjiga> Model = ctx.Knjiga.ToList();
            return View(Model);
        }

        public ActionResult Create()
        {            
            return View();
        }        

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
            knjiga.KnjigaKategorijas = k.KnjigaKategorijas;
            
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Knjiga k = ctx.Knjiga.Find(id);
            ctx.Knjiga.Remove(k);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }
       
        public ActionResult Details(int id)
        {
            Knjiga Model = ctx.Knjiga.Find(id);
            return View(Model);
        }
    }
}
