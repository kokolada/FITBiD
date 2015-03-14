using FITBiD_empty.DAL;
using FITBiD_empty.Helper;
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
	public class KeysRecordController : Controller
	{
		MojContext ctx = new MojContext();
		public ActionResult Index()
		{
			KeysRecordViewModel Model = new KeysRecordViewModel();
			Model.listaEvidencijaKljuceva = ctx.EvidencijaKljuceva
				.Select(x => new KeysRecordViewModel.KeyRecordInfo() {
					Id = x.Id,
					NazivUcionice = x.Kljuc.Ucionica.Naziv,
					NastavnoOsoblje = x.NastavnoOsoblje.Ime + " " + x.NastavnoOsoblje.Prezime,
					BarKodKljuca = x.Kljuc.Barcode,
					DatumPreuzimanja = x.DatumPreuzimanja,
					DatumVracanja = x.DatumVracanja
				}).Where(y => y.DatumVracanja == null && y.DatumPreuzimanja.Day == DateTime.Today.Day).ToList();
			
			return View(Model);
		}

		public ActionResult Details(int id)
		{
			return View();
		}

		public ActionResult Create()
		{
			KeysRecordCreateViewModel Model = new KeysRecordCreateViewModel();
			Model.ListaKljuceva = ctx.Kljuc.Include(x => x.Ucionica).ToList();
			Model.ListaOsoblja = ctx.NastavnoOsoblje.ToList();
			Model.DatumPreuzimanja = DateTime.Now;
			return View(Model);
		}
		[HttpPost]
		public ActionResult Create(int Nastavnik, int Kljuc) {
		    if (Nastavnik == -1 || Kljuc==-1)
		    {
                KeysRecordCreateViewModel Model = new KeysRecordCreateViewModel();
                Model.ListaKljuceva = ctx.Kljuc.Include(x => x.Ucionica).ToList();
                Model.ListaOsoblja = ctx.NastavnoOsoblje.ToList();
                Model.DatumPreuzimanja = DateTime.Now;
                return View(Model);
		    }
			EvidencijaKljuceva evK = new EvidencijaKljuceva();
			evK.KljucId = Kljuc;
			evK.NastavnoOsobljeId = Nastavnik;
			evK.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
			evK.DatumPreuzimanja = DateTime.Now;

			ctx.EvidencijaKljuceva.Add(evK);
			ctx.SaveChanges();

			return RedirectToAction("Index","Workers");
		}

		public ActionResult Edit(int id)
		{
			return View();
		}

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

		public ActionResult Delete(int id)
		{
			return View();
		}

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
