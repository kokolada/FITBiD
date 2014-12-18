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
       
        public ActionResult Index()
        {
            List<EvidencijaKnjigaZaProdaju> Model = ctx.EvidencijaKnjigaZaProdaju.ToList();
            return View(Model);
        }

        public ActionResult Details(int id)
        {
            EvidencijaKnjigaZaProdaju Model = ctx.EvidencijaKnjigaZaProdaju.Find(id);
            return View(Model);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            EvidencijaKnjigaZaProdaju Model = ctx.EvidencijaKnjigaZaProdaju.Find(id);
            return View(Model);
        }

        public ActionResult Delete(int id)
        {
            EvidencijaKnjigaZaProdaju evidencija = ctx.EvidencijaKnjigaZaProdaju.Find(id);
            ctx.EvidencijaKnjigaZaProdaju.Remove(evidencija);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Save(EvidencijaKnjigaZaProdaju evidencija) 
        {
            EvidencijaKnjigaZaProdaju e;
            if (evidencija.Id == 0)
            {
                e = new EvidencijaKnjigaZaProdaju();
                ctx.EvidencijaKnjigaZaProdaju.Add(e);
            }
            else
                e = ctx.EvidencijaKnjigaZaProdaju.Find(evidencija.Id);

            e.Knjiga = evidencija.Knjiga;
            e.KnjigaId = evidencija.KnjigaId;
            e.Radnik = evidencija.Radnik;
            e.RadnikId = evidencija.RadnikId;
            e.DatumEvidencije = evidencija.DatumEvidencije;

            ctx.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}
