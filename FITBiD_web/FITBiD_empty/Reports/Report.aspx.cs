using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FITBiD_empty.DAL;
using FITBiD_empty.Models;
using FITBiD_empty.Reporti;
using Microsoft.Reporting.WebForms;

namespace FITBiD_empty
{
    public partial class report : System.Web.UI.Page
    {
        MojContext ctx = new MojContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            DS_Knjige ds = new DS_Knjige();

            if (Session["Report"].ToString() == "Knjige")
            {
                List<Knjiga> lista = ctx.Knjiga.ToList();
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reporti/rpt_Knjige.rdlc");
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSKnjige", lista));
            }
            else
                if (Session["Report"].ToString() == "Studenti")
                {
                    List<Student> lista = ctx.Student.ToList();
                   
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reporti/rpt_Studenti.rdlc");
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSStudenti", lista));
                }
                else
                    if (Session["Report"].ToString() == "Osoblje")
                    {
                        List<NastavnoOsoblje> lista = ctx.NastavnoOsoblje.ToList();
                        ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reporti/rpt_Osoblje.rdlc");
                        ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSOsoblje", lista));
                    }
                    else
                        if (Session["Report"].ToString() == "Radnici")
                        {
                            List<Radnik> lista = ctx.Radnik.ToList();
                            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reporti/rpt_Radnici.rdlc");
                            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSRadnici", lista));
                        }
        }
    }
}