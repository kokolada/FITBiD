﻿using FITBiD_empty.DAL;
using FITBiD_empty.Helper;
using FITBiD_empty.Models;
using FITBiD_empty.ViewModels;
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
			EvidencijaIznajmljivanjaKnjigaViewModel Model = new EvidencijaIznajmljivanjaKnjigaViewModel();
			Model.Knjige = ctx.Knjiga.ToList();
			Model.Studenti = ctx.Student.ToList();

			return View(Model);
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

		public ActionResult Save(int knjiga, int student)
		{
			EvidencijaKnjigaZaIznajmljivanje evIZ = new EvidencijaKnjigaZaIznajmljivanje();
			evIZ.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
			evIZ.KnjigaId = knjiga;
			evIZ.StudentId = student;
			evIZ.DatumIzdavanja = DateTime.Now;

			ctx.EvidencijaKnjigaZaIznajmljivanje.Add(evIZ);
			ctx.SaveChanges();

			return RedirectToAction("Index", "Workers");
		}

	   
	}
}
