﻿namespace FITBiD.Forms
{
    partial class BookSales
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Knjiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaObajvljivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSKnjige = new FITBiD.DA.DSKnjige();
            this.nazivKnjige = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.knjigasTableAdapter = new FITBiD.DA.DSKnjigeTableAdapters.KnjigasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.datumPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radnikTxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Cijena,
            this.ImePrezime,
            this.Knjiga,
            this.GodinaObajvljivanja,
            this.Autor});
            this.dataGridView.Location = new System.Drawing.Point(15, 87);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(645, 328);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumEvidencije";
            this.Datum.HeaderText = "Datum prodaje";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Ime i prezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Knjiga
            // 
            this.Knjiga.DataPropertyName = "Naziv";
            this.Knjiga.HeaderText = "Knjiga";
            this.Knjiga.Name = "Knjiga";
            this.Knjiga.ReadOnly = true;
            // 
            // GodinaObajvljivanja
            // 
            this.GodinaObajvljivanja.DataPropertyName = "Godina objavljivanja";
            this.GodinaObajvljivanja.HeaderText = "Izdano";
            this.GodinaObajvljivanja.Name = "GodinaObajvljivanja";
            this.GodinaObajvljivanja.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // knjigasBindingSource
            // 
            this.knjigasBindingSource.DataMember = "Knjigas";
            this.knjigasBindingSource.DataSource = this.dSKnjige;
            // 
            // dSKnjige
            // 
            this.dSKnjige.DataSetName = "DSKnjige";
            this.dSKnjige.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazivKnjige
            // 
            this.nazivKnjige.Location = new System.Drawing.Point(56, 13);
            this.nazivKnjige.Name = "nazivKnjige";
            this.nazivKnjige.Size = new System.Drawing.Size(159, 20);
            this.nazivKnjige.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // knjigasTableAdapter
            // 
            this.knjigasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Knjiga";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(582, 11);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Print";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // datumPicker
            // 
            this.datumPicker.Location = new System.Drawing.Point(272, 13);
            this.datumPicker.Name = "datumPicker";
            this.datumPicker.Size = new System.Drawing.Size(200, 20);
            this.datumPicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Radnik";
            // 
            // radnikTxb
            // 
            this.radnikTxb.Location = new System.Drawing.Point(56, 43);
            this.radnikTxb.Name = "radnikTxb";
            this.radnikTxb.Size = new System.Drawing.Size(159, 20);
            this.radnikTxb.TabIndex = 7;
            // 
            // BookSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 431);
            this.Controls.Add(this.radnikTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datumPicker);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nazivKnjige);
            this.Controls.Add(this.dataGridView);
            this.Name = "BookSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodate knjige";
            this.Load += new System.EventHandler(this.BookSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox nazivKnjige;
        private System.Windows.Forms.Button button1;
        private DA.DSKnjige dSKnjige;
        private System.Windows.Forms.BindingSource knjigasBindingSource;
        private DA.DSKnjigeTableAdapters.KnjigasTableAdapter knjigasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Knjiga;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaObajvljivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.DateTimePicker datumPicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox radnikTxb;
    }
}