namespace FITBiD.Forms
{
	partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtGodinaObjavljivanja = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtOznakaStalaze = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cbxZaProdaju = new System.Windows.Forms.CheckBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Godina objavljivanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barcode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Oznaka stalaže";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Za prodaju?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cijena";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(176, 47);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(132, 20);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtGodinaObjavljivanja
            // 
            this.txtGodinaObjavljivanja.Location = new System.Drawing.Point(176, 73);
            this.txtGodinaObjavljivanja.Name = "txtGodinaObjavljivanja";
            this.txtGodinaObjavljivanja.Size = new System.Drawing.Size(132, 20);
            this.txtGodinaObjavljivanja.TabIndex = 8;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(176, 99);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(132, 20);
            this.txtAutor.TabIndex = 9;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(176, 125);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(132, 20);
            this.txtBarcode.TabIndex = 10;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // txtOznakaStalaze
            // 
            this.txtOznakaStalaze.Location = new System.Drawing.Point(176, 151);
            this.txtOznakaStalaze.Name = "txtOznakaStalaze";
            this.txtOznakaStalaze.Size = new System.Drawing.Size(132, 20);
            this.txtOznakaStalaze.TabIndex = 11;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(176, 199);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(132, 20);
            this.txtCijena.TabIndex = 12;
            this.txtCijena.TextChanged += new System.EventHandler(this.txtCijena_TextChanged);
            // 
            // cbxZaProdaju
            // 
            this.cbxZaProdaju.AutoSize = true;
            this.cbxZaProdaju.Location = new System.Drawing.Point(176, 179);
            this.cbxZaProdaju.Name = "cbxZaProdaju";
            this.cbxZaProdaju.Size = new System.Drawing.Size(15, 14);
            this.cbxZaProdaju.TabIndex = 13;
            this.cbxZaProdaju.UseVisualStyleBackColor = true;
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(176, 240);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(62, 23);
            this.btnPonisti.TabIndex = 14;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(244, 240);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(64, 23);
            this.btnSacuvaj.TabIndex = 15;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 272);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje knjige";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 309);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.cbxZaProdaju);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtOznakaStalaze);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtGodinaObjavljivanja);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj knjigu";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.TextBox txtGodinaObjavljivanja;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.TextBox txtOznakaStalaze;
		private System.Windows.Forms.TextBox txtCijena;
		private System.Windows.Forms.CheckBox cbxZaProdaju;
		private System.Windows.Forms.Button btnPonisti;
		private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox groupBox1;
	}
}