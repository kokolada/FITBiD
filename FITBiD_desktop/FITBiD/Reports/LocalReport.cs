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

namespace FITBiD.Reports {
	public partial class LocalReport : Form {
		public LocalReport() {
			InitializeComponent();
		}

		private void LocalReport_Load(object sender, EventArgs e) {

			DA.DSEvidencijaIspitnogMaterijala dsIspitniMaterijal = new DA.DSEvidencijaIspitnogMaterijala();
			DA.DSEvidencijaIspitnogMaterijalaTableAdapters.EvidencijaIspitnogMaterijalaTableAdapter adapter = new DA.DSEvidencijaIspitnogMaterijalaTableAdapters.EvidencijaIspitnogMaterijalaTableAdapter();

			adapter.Fill(dsIspitniMaterijal.EvidencijaIspitnogMaterijala);
			bindingSource.DataSource = dsIspitniMaterijal.EvidencijaIspitnogMaterijala;

			ReportDataSource rds = new ReportDataSource("EvidencijaIspitnogMaterijala", bindingSource);
			reportViewer.LocalReport.DataSources.Add(rds);


			this.reportViewer.RefreshReport();
		}
	}
}
