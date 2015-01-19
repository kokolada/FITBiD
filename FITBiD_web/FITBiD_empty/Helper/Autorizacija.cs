using System.Collections.Generic;
using System.Web.Mvc;
using FITBiD_empty.ViewModels;

namespace FITBiD_empty.Helper
{
	public class Autorizacija : FilterAttribute, IAuthorizationFilter
	{
		string _rola;
		public Autorizacija(string rola = "")
		{
			_rola = rola;
		}

		public void OnAuthorization(AuthorizationContext filterContext)
		{
			Korisnik k = Autentifikacija.GetLogiraniKorisnik(filterContext.HttpContext);

			if (k == null)
			{
				filterContext.HttpContext.Response.Redirect("/Login");
			}

		}
	}
}