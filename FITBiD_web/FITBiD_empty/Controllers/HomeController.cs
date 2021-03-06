﻿using FITBiD_empty.DAL;
using FITBiD_empty.Helper;
using FITBiD_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
	[Autorizacija]
	public class HomeController : Controller
	{
		MojContext ctx = new MojContext();

		public ActionResult Index()
		{
			Ucionica uc = ctx.Ucionica.FirstOrDefault();
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		
	}
}