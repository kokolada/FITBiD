namespace FITBiD.Forms
{
    partial class StudentDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgIznajmljene = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgRezervisane = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtRezervisane = new System.Windows.Forms.Label();
            this.txtIznajmljene = new System.Windows.Forms.Label();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervacijaPotvrdjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVracanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv_knjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vracena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIznajmljene)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervisane)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIndex);
            this.groupBox1.Controls.Add(this.Ime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lični podaci";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Index : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prezime :";
            // 
            // txtIme
            // 
            this.txtIme.AutoSize = true;
            this.txtIme.Location = new System.Drawing.Point(69, 24);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(35, 13);
            this.txtIme.TabIndex = 5;
            this.txtIme.Text = "label3";
            // 
            // txtPrezime
            // 
            this.txtPrezime.AutoSize = true;
            this.txtPrezime.Location = new System.Drawing.Point(69, 48);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(35, 13);
            this.txtPrezime.TabIndex = 6;
            this.txtPrezime.Text = "label8";
            // 
            // txtIndex
            // 
            this.txtIndex.AutoSize = true;
            this.txtIndex.Location = new System.Drawing.Point(69, 72);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(35, 13);
            this.txtIndex.TabIndex = 7;
            this.txtIndex.Text = "label9";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(33, 24);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(30, 13);
            this.Ime.TabIndex = 0;
            this.Ime.Text = "Ime :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgIznajmljene);
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 158);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Iznajmljene knjige";
            // 
            // dgIznajmljene
            // 
            this.dgIznajmljene.AllowUserToAddRows = false;
            this.dgIznajmljene.AllowUserToDeleteRows = false;
            this.dgIznajmljene.AllowUserToResizeColumns = false;
            this.dgIznajmljene.AllowUserToResizeRows = false;
            this.dgIznajmljene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIznajmljene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumIzdavanja,
            this.DatumVracanja,
            this.Naziv_knjige,
            this.Vracena});
            this.dgIznajmljene.Location = new System.Drawing.Point(6, 19);
            this.dgIznajmljene.MultiSelect = false;
            this.dgIznajmljene.Name = "dgIznajmljene";
            this.dgIznajmljene.ReadOnly = true;
            this.dgIznajmljene.RowHeadersVisible = false;
            this.dgIznajmljene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgIznajmljene.Size = new System.Drawing.Size(395, 133);
            this.dgIznajmljene.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgRezervisane);
            this.groupBox3.Location = new System.Drawing.Point(12, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 164);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rezervacije knjiga";
            // 
            // dgRezervisane
            // 
            this.dgRezervisane.AllowUserToAddRows = false;
            this.dgRezervisane.AllowUserToDeleteRows = false;
            this.dgRezervisane.AllowUserToResizeColumns = false;
            this.dgRezervisane.AllowUserToResizeRows = false;
            this.dgRezervisane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRezervisane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumRezervacije,
            this.RezervacijaPotvrdjena,
            this.Naziv});
            this.dgRezervisane.Location = new System.Drawing.Point(6, 19);
            this.dgRezervisane.MultiSelect = false;
            this.dgRezervisane.Name = "dgRezervisane";
            this.dgRezervisane.ReadOnly = true;
            this.dgRezervisane.RowHeadersVisible = false;
            this.dgRezervisane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRezervisane.Size = new System.Drawing.Size(395, 139);
            this.dgRezervisane.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervisanih knjiga:  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iznajmljenih knjiga: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefon : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTelefon);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Location = new System.Drawing.Point(208, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kontakt";
            // 
            // txtTelefon
            // 
            this.txtTelefon.AutoSize = true;
            this.txtTelefon.Location = new System.Drawing.Point(69, 25);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(41, 13);
            this.txtTelefon.TabIndex = 8;
            this.txtTelefon.Text = "label10";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(69, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(41, 13);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "label11";
            // 
            // txtRezervisane
            // 
            this.txtRezervisane.AutoSize = true;
            this.txtRezervisane.Location = new System.Drawing.Point(111, 296);
            this.txtRezervisane.Name = "txtRezervisane";
            this.txtRezervisane.Size = new System.Drawing.Size(41, 13);
            this.txtRezervisane.TabIndex = 10;
            this.txtRezervisane.Text = "label12";
            // 
            // txtIznajmljene
            // 
            this.txtIznajmljene.AutoSize = true;
            this.txtIznajmljene.Location = new System.Drawing.Point(104, 485);
            this.txtIznajmljene.Name = "txtIznajmljene";
            this.txtIznajmljene.Size = new System.Drawing.Size(41, 13);
            this.txtIznajmljene.TabIndex = 11;
            this.txtIznajmljene.Text = "label13";
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            // 
            // RezervacijaPotvrdjena
            // 
            this.RezervacijaPotvrdjena.DataPropertyName = "RezervacijaPotvrdjena";
            this.RezervacijaPotvrdjena.HeaderText = "Rezervacija potvrđena";
            this.RezervacijaPotvrdjena.Name = "RezervacijaPotvrdjena";
            this.RezervacijaPotvrdjena.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.HeaderText = "Izdata";
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            // 
            // DatumVracanja
            // 
            this.DatumVracanja.DataPropertyName = "DatumVracanja";
            this.DatumVracanja.HeaderText = "Datum vracanja";
            this.DatumVracanja.Name = "DatumVracanja";
            this.DatumVracanja.ReadOnly = true;
            // 
            // Naziv_knjige
            // 
            this.Naziv_knjige.DataPropertyName = "Naziv";
            this.Naziv_knjige.HeaderText = "Naziv";
            this.Naziv_knjige.Name = "Naziv_knjige";
            this.Naziv_knjige.ReadOnly = true;
            // 
            // Vracena
            // 
            this.Vracena.DataPropertyName = "Vracena";
            this.Vracena.HeaderText = "Vraćena";
            this.Vracena.Name = "Vracena";
            this.Vracena.ReadOnly = true;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 507);
            this.Controls.Add(this.txtIznajmljene);
            this.Controls.Add(this.txtRezervisane);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentDetails";
            this.Text = "Podaci o studentu";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIznajmljene)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervisane)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txtIme;
        private System.Windows.Forms.Label txtPrezime;
        private System.Windows.Forms.Label txtIndex;
        private System.Windows.Forms.DataGridView dgIznajmljene;
        private System.Windows.Forms.DataGridView dgRezervisane;
        private System.Windows.Forms.Label txtTelefon;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtRezervisane;
        private System.Windows.Forms.Label txtIznajmljene;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaPotvrdjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVracanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv_knjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vracena;
    }
}