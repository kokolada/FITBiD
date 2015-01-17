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
		public Reports() {
			InitializeComponent();
		}

		private void Reports_Load(object sender, EventArgs e) {
			DA.DSStudents dsStudents = new DA.DSStudents();
			DA.DSStudentsTableAdapters.Studenti_ViewTableAdapter adapter = new DA.DSStudentsTableAdapters.Studenti_ViewTableAdapter();

			bindingSource.DataSource = dsStudents.Studenti_View;

			adapter.Fill(dsStudents.Studenti_View);
			ReportDataSource reportDS = new ReportDataSource("Students",bindingSource);
			reportViewer.LocalReport.DataSources.Add(reportDS);
			

			this.reportViewer.RefreshReport();
		}
	}
}
