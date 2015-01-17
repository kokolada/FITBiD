using FITBiD_empty.DAL;
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
					Session.Add("user", user);
					return Redirect("/");
				}
				else
				{
					var student = ctx.Student.Where(x => x.BrojIndeksa == username).Where(x => x.Password == password).FirstOrDefault();
					if (student != null)
					{
						Session.Add("user", student);
						return Redirect("/Profile/Index?studentId=1");
					}
				}
			}
			return View("Login");
		}
	}
}