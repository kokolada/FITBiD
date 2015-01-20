using FITBiD_empty.DAL;
using FITBiD_empty.Helper;
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

					Autentifikacija.PokreniNovuSesiju(k, HttpContext,false);

					return Redirect("/");	
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

						Autentifikacija.PokreniNovuSesiju(k, HttpContext, true);

						return Redirect("/Profile/Index?studentId=1");
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