using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class CategoryController : Controller
    {
        MojContext ctx = new MojContext();
        
        public ActionResult Index()
        {
            List<KategorijaKnjige> Model = ctx.KategorijaKnjige.ToList();
            return View(Model);
        }

        public ActionResult Details(int id)
        {
            KategorijaKnjige Model = ctx.KategorijaKnjige.Find(id);
            return View(Model);
        }

        public ActionResult Create()
        {
            return View();
        }
        
        public ActionResult Edit(int id)
        {
            KategorijaKnjige Model = ctx.KategorijaKnjige.Find(id);
            return View(Model);
        }

        public ActionResult Save(KategorijaKnjige kategorija) 
        {
            KategorijaKnjige k;
            if (kategorija.Id == 0)
            {
                k = new KategorijaKnjige();
                ctx.KategorijaKnjige.Add(k);
            }
            else
                k = ctx.KategorijaKnjige.Find(kategorija.Id);

            k.Naziv = kategorija.Naziv;
            k.KnjigaKategorijas = kategorija.KnjigaKategorijas;
            
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int id)
        {
            KategorijaKnjige kategorija = ctx.KategorijaKnjige.Find(id);
            ctx.KategorijaKnjige.Remove(kategorija);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
