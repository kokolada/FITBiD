using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FITBiD.DA;
using Microsoft.Reporting.WinForms;

namespace FITBiD.Reports {
	public partial class BookSalesReport : Form {
		
		DSEvidencijaProdaje dsEvidencijaProdaje = new DSEvidencijaProdaje();

		public BookSalesReport(DSEvidencijaProdaje.EvidencijaKnjigaZaProdajusDataTable dtBookSales) {
			InitializeComponent();
			DSEvidencijaProdajeBindingSource.DataSource = dtBookSales;
		}

		private void BookSalesReport_Load(object sender, EventArgs e) {
			
			ReportDataSource rds = new ReportDataSource("BookSales",DSEvidencijaProdajeBindingSource);
			reportViewer.LocalReport.DataSources.Add(rds);

			this.reportViewer.RefreshReport();
		}
	}
}
