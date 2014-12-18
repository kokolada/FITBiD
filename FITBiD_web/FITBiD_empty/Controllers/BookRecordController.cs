using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class BookRecordController : Controller
    {
        MojContext ctx = new MojContext();
        
        public ActionResult Index()
        {
            List<EvidencijaKnjigaZaIznajmljivanje> Model = ctx.EvidencijaKnjigaZaIznajmljivanje.ToList();
            return View(Model);
        }

        public ActionResult Details(int id)
        {
            EvidencijaKnjigaZaIznajmljivanje Model = ctx.EvidencijaKnjigaZaIznajmljivanje.Find(id);
            return View(Model);
        }
        
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            EvidencijaKnjigaZaIznajmljivanje Model = ctx.EvidencijaKnjigaZaIznajmljivanje.Find(id);
            return View(Model);
        }

        public ActionResult Delete(int id)
        {
            EvidencijaKnjigaZaIznajmljivanje evidencija = ctx.EvidencijaKnjigaZaIznajmljivanje.Find(id);
            ctx.EvidencijaKnjigaZaIznajmljivanje.Remove(evidencija);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Save(EvidencijaKnjigaZaIznajmljivanje evidencija)
        {
            EvidencijaKnjigaZaIznajmljivanje e;
            if (evidencija.Id == 0)
            {
                e = new EvidencijaKnjigaZaIznajmljivanje();
                ctx.EvidencijaKnjigaZaIznajmljivanje.Add(e);
            }
            else
                e = ctx.EvidencijaKnjigaZaIznajmljivanje.Find(evidencija.Id);

            //e.Knjiga = evidencija.Knjiga;
            //e.KnjigaId = evidencija.KnjigaId;
            //e.Radnik = evidencija.Radnik;
            //e.RadnikId = evidencija.RadnikId;
            //e.Student = evidencija.Student;
            //e.StudentId = evidencija.StudentId;
            //e.DatumIzdavanja = evidencija.DatumIzdavanja;
            //e.DatumVracanja = evidencija.DatumVracanja;

            ctx.SaveChanges();

            return RedirectToAction("Index");
        }

       
    }
}
