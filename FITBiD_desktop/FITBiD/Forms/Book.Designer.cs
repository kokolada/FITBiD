﻿namespace FITBiD.Forms
{
    partial class Book
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtGodina = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.Label();
            this.txtStalaza = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.prodaja = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stalaza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Za prodaju";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cijena";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGodina
            // 
            this.txtGodina.AutoSize = true;
            this.txtGodina.Location = new System.Drawing.Point(179, 58);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(35, 13);
            this.txtGodina.TabIndex = 8;
            this.txtGodina.Text = "label8";
            // 
            // txtAutor
            // 
            this.txtAutor.AutoSize = true;
            this.txtAutor.Location = new System.Drawing.Point(179, 80);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(35, 13);
            this.txtAutor.TabIndex = 9;
            this.txtAutor.Text = "label9";
            // 
            // txtBarcode
            // 
            this.txtBarcode.AutoSize = true;
            this.txtBarcode.Location = new System.Drawing.Point(179, 104);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(41, 13);
            this.txtBarcode.TabIndex = 10;
            this.txtBarcode.Text = "label10";
            // 
            // txtStalaza
            // 
            this.txtStalaza.AutoSize = true;
            this.txtStalaza.Location = new System.Drawing.Point(179, 128);
            this.txtStalaza.Name = "txtStalaza";
            this.txtStalaza.Size = new System.Drawing.Size(41, 13);
            this.txtStalaza.TabIndex = 11;
            this.txtStalaza.Text = "label11";
            // 
            // txtCijena
            // 
            this.txtCijena.AutoSize = true;
            this.txtCijena.Location = new System.Drawing.Point(179, 174);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(41, 13);
            this.txtCijena.TabIndex = 13;
            this.txtCijena.Text = "label13";
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Location = new System.Drawing.Point(179, 33);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(0, 13);
            this.txtNaziv.TabIndex = 14;
            // 
            // prodaja
            // 
            this.prodaja.AutoSize = true;
            this.prodaja.Location = new System.Drawing.Point(182, 154);
            this.prodaja.Name = "prodaja";
            this.prodaja.Size = new System.Drawing.Size(15, 14);
            this.prodaja.TabIndex = 15;
            this.prodaja.UseVisualStyleBackColor = true;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.prodaja);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtStalaza);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtGodina;
        private System.Windows.Forms.Label txtAutor;
        private System.Windows.Forms.Label txtBarcode;
        private System.Windows.Forms.Label txtStalaza;
        private System.Windows.Forms.Label txtCijena;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.CheckBox prodaja;
    }
}