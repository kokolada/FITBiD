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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dSKnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSKnjige = new FITBiD.DA.DSKnjige();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKnjiga = new System.Windows.Forms.TextBox();
            this.txtAutorrr = new System.Windows.Forms.TextBox();
            this.cbxProdaja = new System.Windows.Forms.CheckBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBroj = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgPretraga = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaObjavljivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaProdaju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjigeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjige)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Knjiga";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(112, 194);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pretraga";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKnjiga);
            this.groupBox1.Controls.Add(this.txtAutorrr);
            this.groupBox1.Controls.Add(this.cbxProdaja);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // txtKnjiga
            // 
            this.txtKnjiga.Location = new System.Drawing.Point(75, 30);
            this.txtKnjiga.Name = "txtKnjiga";
            this.txtKnjiga.Size = new System.Drawing.Size(100, 20);
            this.txtKnjiga.TabIndex = 14;
            // 
            // txtAutorrr
            // 
            this.txtAutorrr.Location = new System.Drawing.Point(75, 58);
            this.txtAutorrr.Name = "txtAutorrr";
            this.txtAutorrr.Size = new System.Drawing.Size(100, 20);
            this.txtAutorrr.TabIndex = 13;
            // 
            // cbxProdaja
            // 
            this.cbxProdaja.AutoSize = true;
            this.cbxProdaja.Location = new System.Drawing.Point(75, 118);
            this.cbxProdaja.Name = "cbxProdaja";
            this.cbxProdaja.Size = new System.Drawing.Size(15, 14);
            this.cbxProdaja.TabIndex = 12;
            this.cbxProdaja.UseVisualStyleBackColor = true;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(75, 87);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(100, 20);
            this.txtBarcode.TabIndex = 11;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(75, 148);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(36, 20);
            this.txtMin.TabIndex = 10;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(139, 148);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(36, 20);
            this.txtMax.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "do";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cijena od";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prodaja";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barcode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBroj);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgPretraga);
            this.groupBox2.Location = new System.Drawing.Point(212, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 233);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Knjige";
            // 
            // txtBroj
            // 
            this.txtBroj.AutoSize = true;
            this.txtBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBroj.Location = new System.Drawing.Point(92, 217);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(35, 13);
            this.txtBroj.TabIndex = 12;
            this.txtBroj.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Pronađeno knjiga: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "* Dupli klik na knjigu otvara detaljnije informacije";
            // 
            // dgPretraga
            // 
            this.dgPretraga.AllowUserToAddRows = false;
            this.dgPretraga.AllowUserToDeleteRows = false;
            this.dgPretraga.AllowUserToResizeColumns = false;
            this.dgPretraga.AllowUserToResizeRows = false;
            this.dgPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.GodinaObjavljivanja,
            this.Autor,
            this.Barcode,
            this.ZaProdaju,
            this.Cijena});
            this.dgPretraga.Location = new System.Drawing.Point(6, 30);
            this.dgPretraga.MultiSelect = false;
            this.dgPretraga.Name = "dgPretraga";
            this.dgPretraga.ReadOnly = true;
            this.dgPretraga.RowHeadersVisible = false;
            this.dgPretraga.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPretraga.Size = new System.Drawing.Size(587, 187);
            this.dgPretraga.TabIndex = 0;
            this.dgPretraga.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgPretraga_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // GodinaObjavljivanja
            // 
            this.GodinaObjavljivanja.DataPropertyName = "GodinaObjavljivanja";
            this.GodinaObjavljivanja.HeaderText = "Godina";
            this.GodinaObjavljivanja.Name = "GodinaObjavljivanja";
            this.GodinaObjavljivanja.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // ZaProdaju
            // 
            this.ZaProdaju.DataPropertyName = "ZaProdaju";
            this.ZaProdaju.HeaderText = "Prodaja";
            this.ZaProdaju.Name = "ZaProdaju";
            this.ZaProdaju.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena(KM)";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 260);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga knjiga";
            this.Load += new System.EventHandler(this.BookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjigeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjige)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPretraga)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.BindingSource dSKnjigeBindingSource;
        private DA.DSKnjige dSKnjige;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxProdaja;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.DataGridView dgPretraga;
        private System.Windows.Forms.Label txtBroj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAutorrr;
        private System.Windows.Forms.TextBox txtKnjiga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaObjavljivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaProdaju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
	}
}