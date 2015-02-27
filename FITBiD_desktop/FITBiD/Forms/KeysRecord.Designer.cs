namespace FITBiD.Forms {
	partial class KeysRecord {
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
			this.datumPreuzimanja = new System.Windows.Forms.DateTimePicker();
			this.datumVracanja = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxOsoblje = new System.Windows.Forms.ComboBox();
			this.cbxKljuc = new System.Windows.Forms.ComboBox();
			this.cbxRadnik = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// datumPreuzimanja
			// 
			this.datumPreuzimanja.Location = new System.Drawing.Point(167, 31);
			this.datumPreuzimanja.Name = "datumPreuzimanja";
			this.datumPreuzimanja.Size = new System.Drawing.Size(200, 20);
			this.datumPreuzimanja.TabIndex = 0;
			// 
			// datumVracanja
			// 
			this.datumVracanja.Location = new System.Drawing.Point(167, 68);
			this.datumVracanja.Name = "datumVracanja";
			this.datumVracanja.Size = new System.Drawing.Size(200, 20);
			this.datumVracanja.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Datum preuzimanja";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Datum vraćanja";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nastavno osoblje";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Učionica";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Radnik";
			// 
			// cbxOsoblje
			// 
			this.cbxOsoblje.FormattingEnabled = true;
			this.cbxOsoblje.Location = new System.Drawing.Point(123, 13);
			this.cbxOsoblje.Name = "cbxOsoblje";
			this.cbxOsoblje.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbxOsoblje.Size = new System.Drawing.Size(200, 21);
			this.cbxOsoblje.TabIndex = 7;
			// 
			// cbxKljuc
			// 
			this.cbxKljuc.FormattingEnabled = true;
			this.cbxKljuc.Location = new System.Drawing.Point(123, 43);
			this.cbxKljuc.Name = "cbxKljuc";
			this.cbxKljuc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbxKljuc.Size = new System.Drawing.Size(200, 21);
			this.cbxKljuc.TabIndex = 8;
			// 
			// cbxRadnik
			// 
			this.cbxRadnik.FormattingEnabled = true;
			this.cbxRadnik.Location = new System.Drawing.Point(123, 100);
			this.cbxRadnik.Name = "cbxRadnik";
			this.cbxRadnik.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbxRadnik.Size = new System.Drawing.Size(200, 21);
			this.cbxRadnik.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtBarcode);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbxRadnik);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbxKljuc);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cbxOsoblje);
			this.groupBox1.Location = new System.Drawing.Point(38, 139);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(329, 129);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// txtBarcode
			// 
			this.txtBarcode.Location = new System.Drawing.Point(123, 70);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(200, 20);
			this.txtBarcode.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Barcode";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(291, 284);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Sačuvaj";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// KeysRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 323);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.datumVracanja);
			this.Controls.Add(this.datumPreuzimanja);
			this.Name = "KeysRecord";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "Keys Record";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker datumPreuzimanja;
		private System.Windows.Forms.DateTimePicker datumVracanja;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbxOsoblje;
		private System.Windows.Forms.ComboBox cbxKljuc;
		private System.Windows.Forms.ComboBox cbxRadnik;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.Button button1;
	}
}