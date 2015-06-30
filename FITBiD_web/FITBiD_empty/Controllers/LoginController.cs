using FITBiD_empty.DAL;
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
	public class LoginController : Controller
	{
		// GET: Login
		public ActionResult Index()
		{

			ViewBag.Message = "Login stranica";

			return View("Login");
		}

		[HttpPost]
		public ActionResult Index(string username, string password)
		{
			LoginEvidencija evidencija = new LoginEvidencija();
			evidencija.RadnikId = 1;evidencija.MenadzmentId=1;evidencija.StudentId = 1;
			evidencija.DatumLogina = DateTime.Now;

			using (MojContext ctx = new MojContext())
			{
				var user = ctx.Radnik.Where(x => x.Username == username).Where(x => x.Password == password).FirstOrDefault();
				if (user != null)
				{
					Korisnik k = new Korisnik();
					k.Id = user.Id;
					k.Ime = user.Ime;
					k.Prezime = user.Prezime;
					k.username = user.Username;
					k.password = user.Password;
					k.rola = "radnik";
					evidencija.RadnikId = user.Id;
					Autentifikacija.PokreniNovuSesiju(k, HttpContext,true);
					ctx.LoginEvidencija.Add(evidencija);
					ctx.SaveChanges();
					return RedirectToAction("Index","Workers");	
				}
				else
				{
					var student = ctx.Student.Where(x => x.BrojIndeksa == username).Where(x => x.Password == password).FirstOrDefault();
					if (student != null)
					{
						Korisnik k = new Korisnik();
						k.Id = student.Id;
						k.Ime = student.Ime;
						k.Prezime = student.Prezime;
						k.username = student.BrojIndeksa;
						k.password = student.Password;
						k.rola = "student";
						evidencija.StudentId=student.Id;
						Autentifikacija.PokreniNovuSesiju(k, HttpContext, true);
						ctx.LoginEvidencija.Add(evidencija);
						ctx.SaveChanges();
					    return RedirectToAction("StudentBoard", "Profile");
					}
					var menadzment = ctx.Menadzment.Where(x=>x.Username == username).Where(x=>x.Password ==password).FirstOrDefault();
					if (menadzment != null) {
						Korisnik k = new Korisnik();
						k.Id = menadzment.Id;
						k.Ime = menadzment.Ime;
						k.Prezime = menadzment.Prezime;
						k.username = menadzment.Username;
						k.password = menadzment.Password;
						k.rola = "menadzment";
						evidencija.MenadzmentId=menadzment.Id;
						Autentifikacija.PokreniNovuSesiju(k, HttpContext, true);
						ctx.LoginEvidencija.Add(evidencija);
						ctx.SaveChanges();
						return RedirectToAction("MenadzmentBoard", "Menadzment");
					}
				}
			
			}
			
			return View("Login");
		}

		public ActionResult Logout()
		{
			Autentifikacija.PokreniNovuSesiju(null, HttpContext, true);
			return RedirectToAction("Index");
		}
	}
}