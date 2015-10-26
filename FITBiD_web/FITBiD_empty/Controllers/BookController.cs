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
			Model.ListaKategorija = ctx.KategorijaKnjige.ToList();

			return View(Model);
		}        

		public ActionResult Edit(int bookId)
		{
			Knjiga k = ctx.Knjiga.Find(bookId);

            BookCreateViewModel Model = new BookCreateViewModel()
            {
                Id = bookId,
                Autor = k.Autor,
                BarCode = k.Barcode,
                Cijena = Convert.ToInt32(k.Cijena),
                GodinaObjavljivanja = k.GodinaObjavljivanja,
                Naziv = k.Naziv,
                OznakaStalaze = k.OznakaStalaze,
                ZaProdaju = k.ZaProdaju
            };

            Model.ListaKategorija = ctx.KategorijaKnjige.ToList();
            int kategorijaId = ctx.KnjigaKategorija.Where(x => x.KnjigaId == bookId).FirstOrDefault().KategorijaKnjigeId;
            Model.KategorijaId = kategorijaId;
            return View(Model);
		}

		public ActionResult Save(BookCreateViewModel k, int izabranaKategorijaKnjiga)
		{
			if (ModelState.IsValid)
			{
                bool isEdit = true;
                Knjiga knjiga = ctx.Knjiga.Find(k.Id);
                if (knjiga == null)
                {
                    knjiga = new Knjiga();
                    isEdit = false;
                }
                knjiga.Naziv = k.Naziv;
				knjiga.GodinaObjavljivanja = Convert.ToDateTime(k.GodinaObjavljivanja);
				knjiga.Autor = k.Autor;
				knjiga.Barcode = k.BarCode;
				knjiga.OznakaStalaze = k.OznakaStalaze;
				knjiga.Cijena = k.Cijena;
				knjiga.ZaProdaju = k.ZaProdaju;

                if (!isEdit)
                {
                    ctx.Knjiga.Add(knjiga);
                }
                ctx.SaveChanges();

                if (!isEdit)
                {
                    KnjigaKategorija kkg = new KnjigaKategorija();
                    kkg.KnjigaId = knjiga.Id;
                    kkg.KategorijaKnjigeId = izabranaKategorijaKnjiga;

                    ctx.KnjigaKategorija.Add(kkg);
                    ctx.SaveChanges();
                }	

			}

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
