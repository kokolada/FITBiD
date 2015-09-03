namespace FITBiD.Forms {
	partial class BooksRental {
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
            this.iznajmljeneKnjigeGrid = new System.Windows.Forms.DataGridView();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVracanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Knjiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Radnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.traziBtn = new System.Windows.Forms.Button();
            this.studentTxb = new System.Windows.Forms.TextBox();
            this.radnikTxb = new System.Windows.Forms.TextBox();
            this.knjigaTxb = new System.Windows.Forms.TextBox();
            this.datumVracanjaPicker = new System.Windows.Forms.DateTimePicker();
            this.datumIzdavanjaPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.iznajmljeneKnjigeGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iznajmljeneKnjigeGrid
            // 
            this.iznajmljeneKnjigeGrid.AllowUserToAddRows = false;
            this.iznajmljeneKnjigeGrid.AllowUserToDeleteRows = false;
            this.iznajmljeneKnjigeGrid.AllowUserToResizeColumns = false;
            this.iznajmljeneKnjigeGrid.AllowUserToResizeRows = false;
            this.iznajmljeneKnjigeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iznajmljeneKnjigeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iznajmljeneKnjigeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumIzdavanja,
            this.DatumVracanja,
            this.Knjiga,
            this.Radnik,
            this.Student});
            this.iznajmljeneKnjigeGrid.Location = new System.Drawing.Point(9, 211);
            this.iznajmljeneKnjigeGrid.Name = "iznajmljeneKnjigeGrid";
            this.iznajmljeneKnjigeGrid.RowHeadersVisible = false;
            this.iznajmljeneKnjigeGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.iznajmljeneKnjigeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.iznajmljeneKnjigeGrid.Size = new System.Drawing.Size(618, 280);
            this.iznajmljeneKnjigeGrid.TabIndex = 0;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.HeaderText = "Datum izdavanja";
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            // 
            // DatumVracanja
            // 
            this.DatumVracanja.DataPropertyName = "DatumVracanja";
            this.DatumVracanja.HeaderText = "Datum vraćanja";
            this.DatumVracanja.Name = "DatumVracanja";
            // 
            // Knjiga
            // 
            this.Knjiga.DataPropertyName = "knjiga";
            this.Knjiga.HeaderText = "Knjiga";
            this.Knjiga.Name = "Knjiga";
            // 
            // Radnik
            // 
            this.Radnik.DataPropertyName = "radnik";
            this.Radnik.HeaderText = "Radnik";
            this.Radnik.Name = "Radnik";
            // 
            // Student
            // 
            this.Student.DataPropertyName = "student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.traziBtn);
            this.groupBox1.Controls.Add(this.studentTxb);
            this.groupBox1.Controls.Add(this.radnikTxb);
            this.groupBox1.Controls.Add(this.knjigaTxb);
            this.groupBox1.Controls.Add(this.datumVracanjaPicker);
            this.groupBox1.Controls.Add(this.datumIzdavanjaPicker);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Radnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Knjiga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum vraćanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum izdavanja";
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(447, 155);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(75, 23);
            this.traziBtn.TabIndex = 5;
            this.traziBtn.Text = "Trazi";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // studentTxb
            // 
            this.studentTxb.Location = new System.Drawing.Point(335, 122);
            this.studentTxb.Name = "studentTxb";
            this.studentTxb.Size = new System.Drawing.Size(187, 20);
            this.studentTxb.TabIndex = 4;
            // 
            // radnikTxb
            // 
            this.radnikTxb.Location = new System.Drawing.Point(335, 77);
            this.radnikTxb.Name = "radnikTxb";
            this.radnikTxb.Size = new System.Drawing.Size(187, 20);
            this.radnikTxb.TabIndex = 3;
            // 
            // knjigaTxb
            // 
            this.knjigaTxb.Location = new System.Drawing.Point(335, 33);
            this.knjigaTxb.Name = "knjigaTxb";
            this.knjigaTxb.Size = new System.Drawing.Size(187, 20);
            this.knjigaTxb.TabIndex = 2;
            // 
            // datumVracanjaPicker
            // 
            this.datumVracanjaPicker.Location = new System.Drawing.Point(9, 118);
            this.datumVracanjaPicker.Name = "datumVracanjaPicker";
            this.datumVracanjaPicker.Size = new System.Drawing.Size(200, 20);
            this.datumVracanjaPicker.TabIndex = 1;
            // 
            // datumIzdavanjaPicker
            // 
            this.datumIzdavanjaPicker.Location = new System.Drawing.Point(9, 61);
            this.datumIzdavanjaPicker.Name = "datumIzdavanjaPicker";
            this.datumIzdavanjaPicker.Size = new System.Drawing.Size(200, 20);
            this.datumIzdavanjaPicker.TabIndex = 0;
            // 
            // BooksRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iznajmljeneKnjigeGrid);
            this.Name = "BooksRental";
            this.Text = "Iznajmljivanje";
            this.Load += new System.EventHandler(this.BooksRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iznajmljeneKnjigeGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView iznajmljeneKnjigeGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumVracanja;
		private System.Windows.Forms.DataGridViewTextBoxColumn Knjiga;
		private System.Windows.Forms.DataGridViewTextBoxColumn Radnik;
		private System.Windows.Forms.DataGridViewTextBoxColumn Student;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button traziBtn;
		private System.Windows.Forms.TextBox studentTxb;
		private System.Windows.Forms.TextBox radnikTxb;
		private System.Windows.Forms.TextBox knjigaTxb;
		private System.Windows.Forms.DateTimePicker datumVracanjaPicker;
		private System.Windows.Forms.DateTimePicker datumIzdavanjaPicker;
	}
}