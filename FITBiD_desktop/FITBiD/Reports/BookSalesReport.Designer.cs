namespace FITBiD.Reports {
	partial class BookSalesReport {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.DSEvidencijaProdajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.DSEvidencijaProdajeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer
			// 
			this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource2.Name = "BookSales";
			reportDataSource2.Value = this.DSEvidencijaProdajeBindingSource;
			this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
			this.reportViewer.LocalReport.ReportEmbeddedResource = "FITBiD.Reports.rpt_ProdaneKnjige.rdlc";
			this.reportViewer.Location = new System.Drawing.Point(0, 0);
			this.reportViewer.Name = "reportViewer";
			this.reportViewer.Size = new System.Drawing.Size(544, 383);
			this.reportViewer.TabIndex = 0;
			// 
			// DSEvidencijaProdajeBindingSource
			// 
			this.DSEvidencijaProdajeBindingSource.DataMember = "EvidencijaKnjigaZaProdajus";
			this.DSEvidencijaProdajeBindingSource.DataSource = typeof(FITBiD.DA.DSEvidencijaProdaje);
			// 
			// BookSalesReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 383);
			this.Controls.Add(this.reportViewer);
			this.Name = "BookSalesReport";
			this.Text = "Book Sales Report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.BookSalesReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.DSEvidencijaProdajeBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
		private System.Windows.Forms.BindingSource DSEvidencijaProdajeBindingSource;
	}
}