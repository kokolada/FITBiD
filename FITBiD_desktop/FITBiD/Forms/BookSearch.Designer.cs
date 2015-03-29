namespace FITBiD.Forms
{
	partial class BookSearch
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNazivKnjige = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.gridPretraga = new System.Windows.Forms.DataGridView();
			this.dSKnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dSKnjige = new FITBiD.DA.DSKnjige();
			this.gridDetalji = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridPretraga)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dSKnjigeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dSKnjige)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDetalji)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Naziv knjige";
			// 
			// txtNazivKnjige
			// 
			this.txtNazivKnjige.Location = new System.Drawing.Point(84, 10);
			this.txtNazivKnjige.Name = "txtNazivKnjige";
			this.txtNazivKnjige.Size = new System.Drawing.Size(157, 20);
			this.txtNazivKnjige.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(247, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Autor";
			// 
			// txtAutor
			// 
			this.txtAutor.Location = new System.Drawing.Point(285, 10);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(157, 20);
			this.txtAutor.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(457, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridPretraga
			// 
			this.gridPretraga.AutoGenerateColumns = false;
			this.gridPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPretraga.DataSource = this.dSKnjigeBindingSource;
			this.gridPretraga.Location = new System.Drawing.Point(1, 37);
			this.gridPretraga.Name = "gridPretraga";
			this.gridPretraga.Size = new System.Drawing.Size(546, 150);
			this.gridPretraga.TabIndex = 5;
			// 
			// dSKnjigeBindingSource
			// 
			this.dSKnjigeBindingSource.DataSource = this.dSKnjige;
			this.dSKnjigeBindingSource.Position = 0;
			// 
			// dSKnjige
			// 
			this.dSKnjige.DataSetName = "DSKnjige";
			this.dSKnjige.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridDetalji
			// 
			this.gridDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDetalji.Location = new System.Drawing.Point(1, 193);
			this.gridDetalji.Name = "gridDetalji";
			this.gridDetalji.Size = new System.Drawing.Size(546, 150);
			this.gridDetalji.TabIndex = 6;
			// 
			// BookSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 362);
			this.Controls.Add(this.gridDetalji);
			this.Controls.Add(this.gridPretraga);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtAutor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNazivKnjige);
			this.Controls.Add(this.label1);
			this.Name = "BookSearch";
			this.Text = "BookSearch";
			this.Load += new System.EventHandler(this.BookSearch_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridPretraga)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dSKnjigeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dSKnjige)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDetalji)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNazivKnjige;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView gridPretraga;
		private System.Windows.Forms.DataGridView gridDetalji;
		private System.Windows.Forms.BindingSource dSKnjigeBindingSource;
		private DA.DSKnjige dSKnjige;
	}
}