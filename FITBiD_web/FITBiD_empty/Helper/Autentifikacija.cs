using System;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FITBiD_empty.DAL;
using FITBiD_empty.ViewModels;

namespace FITBiD_empty.Helper
{
	public class Autentifikacija
	{
		private const string LogiraniKorisnik = "logirani_korisnik";

		public static void PokreniNovuSesiju(Korisnik korisnik, HttpContextBase context, bool zapamtiPassword)
		{
			context.Session.Add(LogiraniKorisnik, korisnik);

			if (zapamtiPassword)
			{
				HttpCookie cookie = new HttpCookie("_mvc_session", korisnik != null ? korisnik.Id.ToString() : "");
				cookie.Expires = DateTime.Now.AddDays(10);
				context.Response.Cookies.Add(cookie);
			}
		}

		public static Korisnik GetLogiraniKorisnik(HttpContextBase context)
		{
			Korisnik korisnik = (Korisnik)context.Session[LogiraniKorisnik];

			if (korisnik != null)
				return korisnik;

			return null;
		}

	}
}