using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using FITBiD_empty.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace FITBiD_empty.Controllers
{
    public class BooksReservationController : Controller
    {
        MojContext ctx = new MojContext();
        public ActionResult Index()
        {
			//int id = 0;
			BooksReservationViewModel booksReservationViewModel = new BooksReservationViewModel();
				
			//	booksReservationViewModel.DatumRezervacije = ctx.Rezervacija.FirstOrDefault().DatumRezervacije;
			//	booksReservationViewModel.RezervacijaPotvrdjena = ctx.Rezervacija.FirstOrDefault().RezervacijaPotvrdjena;
			//	booksReservationViewModel.NazivKnjige = ctx.Rezervacija.Include(x=>x.Knjiga).ToString();
			//	booksReservationViewModel.StudentIme = ctx.Rezervacija.Include(u=>u.Student).ToString();

			return View(booksReservationViewModel);
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
		public ActionResult Edit(BooksReservationViewModel booksReservationViewModel) {

			Rezervacija rezervacija = new Rezervacija{

				DatumRezervacije = booksReservationViewModel.DatumRezervacije,
				RezervacijaPotvrdjena = booksReservationViewModel.RezervacijaPotvrdjena,

			};
			if (ModelState.IsValid) {
				
				return RedirectToAction("Edit");
			}

			else { 
			
			return View("Edit",booksReservationViewModel);
			
			}		
		}


        // GET: BooksReservation/Edit/5
        public ActionResult Edit(int id)
        {

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
