namespace FITBiD.Reports {
	partial class LocalReport {
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
			this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer
			// 
			this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer.LocalReport.ReportEmbeddedResource = "FITBiD.Reports.rpt_Materials.rdlc";
			this.reportViewer.Location = new System.Drawing.Point(0, 0);
			this.reportViewer.Name = "reportViewer";
			this.reportViewer.Size = new System.Drawing.Size(650, 399);
			this.reportViewer.TabIndex = 0;
			// 
			// LocalReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 399);
			this.Controls.Add(this.reportViewer);
			this.Name = "LocalReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Evidencija materijala report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.LocalReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
		private System.Windows.Forms.BindingSource bindingSource;
	}
}