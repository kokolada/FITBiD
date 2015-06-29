using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class UploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public ActionResult Index(HttpPostedFileBase file) {
            if (file != null)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/App_Data/Uploads"), fileName);
                    file.SaveAs(path);
                }
            }		

			return RedirectToAction("Index");
		}

    }
}