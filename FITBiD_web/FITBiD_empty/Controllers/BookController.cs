using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Faker;
using FITBiD_empty.ViewModels;

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
			BookCreateViewModel Model = new BookCreateViewModel();
			//u model dodati listu kategorija

			return View(Model);
		}        

		public ActionResult Edit(int bookId)
		{
			Knjiga Model = ctx.Knjiga.Find(bookId);            
			return View(Model);
		}
		
		public ActionResult Save(BookCreateViewModel k)
		{
			//Knjiga knjiga;
			//if (k.Id == 0) {
			//	knjiga = new Knjiga();
			//	ctx.Knjiga.Add(knjiga);
			//}
			//else {
			//	knjiga = ctx.Knjiga.Find(k.Id);
			//}
			Knjiga knjiga = new Knjiga();
			knjiga.Naziv = k.Naziv;
			knjiga.GodinaObjavljivanja = Convert.ToDateTime(k.GodinaObjavljivanja);	
			knjiga.Autor = k.Autor;
			knjiga.Barcode = k.BarCode;
			knjiga.OznakaStalaze = k.OznakaStalaze;
			knjiga.Cijena = k.Cijena;
			knjiga.ZaProdaju = k.ZaProdaju;

			ctx.Knjiga.Add(knjiga);
			ctx.SaveChanges();

			return RedirectToAction("Index","Workers");
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
