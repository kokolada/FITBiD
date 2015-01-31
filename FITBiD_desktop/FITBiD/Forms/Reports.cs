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
				//DA.DSStudents dsStudents = new DA.DSStudents();
				//DA.DSStudentsTableAdapters.Studenti_ViewTableAdapter adapter = new DA.DSStudentsTableAdapters.Studenti_ViewTableAdapter();

				//bindingSource.DataSource = dsStudents.Studenti_View;

				//adapter.Fill(dsStudents.Studenti_View);
				//ReportDataSource reportDS = new ReportDataSource("Students", bindingSource);
				//reportViewer.LocalReport.DataSources.Add(reportDS);
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
				

			this.reportViewer.RefreshReport();
		}
	}
}
