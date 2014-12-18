using FITBiD_empty.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
	public class DAController : Controller
	{
		MojContext ctx = new MojContext();
		//============================================================================================================//
		//OVAJ KONTROLER SE NASLJEDJUJE KADA DRUGI KONTROLER PRISTUPA BAZI; OTHERWISE NASLJEDJUJE SE OBICNI Controller//
		//============================================================================================================//
	}
}