using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using FITBiD_empty.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class BooksReservationController : Controller
    {
        MojContext ctx = new MojContext();
        public ActionResult Index()
        {
            //int id = 0;
            BooksReservationViewModel Model = new BooksReservationViewModel();
            Model.rezervacije = ctx.Rezervacija.Select(x => new BooksReservationViewModel.RezervacijaInfo
            {
                DatumRezervacije = x.DatumRezervacije,
                RezervacijaPotvrdjena = x.RezervacijaPotvrdjena,
                StudentIme = x.Student.Ime,
                NazivKnjige = x.Knjiga.Naziv

            }).ToList();

            return View(Model);
        }

        // GET: BooksReservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksReservation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksReservation/Create
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
		

        // GET: BooksReservation/Edit/5
        public ActionResult Edit(int rezervacijaId)
        {
            Rezervacija r = ctx.Rezervacija.Where(x => x.Id == rezervacijaId).FirstOrDefault();
            var Model = new BooksReservationEditViewModel.RezervacijaInfo
            {
                DatumRezervacije = r.DatumRezervacije,
                RezervacijaPotvrdjena = r.RezervacijaPotvrdjena,

                NazivKnjige = r.Knjiga.Naziv,
                StudentIme = r.Student.Ime

            };
            return View();
        }

        // POST: BooksReservation/Edit/5
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

        // GET: BooksReservation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksReservation/Delete/5
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
