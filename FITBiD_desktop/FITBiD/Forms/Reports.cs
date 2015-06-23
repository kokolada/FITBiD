using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITBiD.Forms {
	public partial class Reports : Form {
		
		string report="";
		public Reports(string report) {
			InitializeComponent();
			this.report = report;
		}

		private void Reports_Load(object sender, EventArgs e) {
			if (report == "students") {
				reportViewer.ServerReport.ReportPath = "/rpt_ListaStudenata";
			}
			else if (report == "izdavanjeKljuceva")
				reportViewer.ServerReport.ReportPath = "/rpt_IzdavanjeKljuceva";
			else if (report == "izdavanjeKnjiga")
				reportViewer.ServerReport.ReportPath = "/rpt_IzdavanjeKnjiga";
			else if (report == "najaktivnijiStudenti")
				reportViewer.ServerReport.ReportPath = "/rpt_NajaktivnijiStudenti";
			else if (report == "najboljiRadnici")
				reportViewer.ServerReport.ReportPath = "/rpt_NajboljiRadnici";
			else if (report == "potrosnjaMaterijala")
				reportViewer.ServerReport.ReportPath = "/rpt_PotrosnjaMaterijala";
			else if (report == "prodajaKnjiga")
				reportViewer.ServerReport.ReportPath = "/rpt_ProdajaKnjiga";
			else if (report == "najaktivnijiStudent")
				reportViewer.ServerReport.ReportPath = "/rpt_NajaktivnijiStudent";
			else if (report == "najaktivnijiStudentPoLoginu")
				reportViewer.ServerReport.ReportPath = "/rpt_NajaktivnijiStudentPoLoginu";
			else if (report == "najzastupljenijeKategorije")
				reportViewer.ServerReport.ReportPath = "/rpt_NajzastupljenijeKategorije";
				

			this.reportViewer.RefreshReport();
		}
	}
}
