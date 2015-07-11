using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FITBiD_empty.Controllers
{
    public class ReportsController : Controller
    {
        //
        // GET: /Reports/
        public ActionResult Knjige()
        {
            Session.Add("Report", "Knjige");
            return Redirect("Report.aspx");
        }
        public ActionResult Studenti()
        {
            Session.Add("Report", "Studenti");
            return Redirect("Report.aspx");
        }
        public ActionResult Osoblje()
        {
            Session.Add("Report", "Osoblje");
            return Redirect("Report.aspx");
        }
        public ActionResult Radnici()
        {
            Session.Add("Report", "Radnici");
            return Redirect("Report.aspx");
        }
	}
}