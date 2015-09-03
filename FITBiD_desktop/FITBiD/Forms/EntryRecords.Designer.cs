namespace FITBiD.Forms {
	partial class EntryRecords {
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
            this.prijaveGrid = new System.Windows.Forms.DataGridView();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnikImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTxb = new System.Windows.Forms.TextBox();
            this.radnikTxb = new System.Windows.Forms.TextBox();
            this.kolicinaTxb = new System.Windows.Forms.TextBox();
            this.traziBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.prijaveGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prijaveGrid
            // 
            this.prijaveGrid.AllowUserToAddRows = false;
            this.prijaveGrid.AllowUserToDeleteRows = false;
            this.prijaveGrid.AllowUserToResizeColumns = false;
            this.prijaveGrid.AllowUserToResizeRows = false;
            this.prijaveGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prijaveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prijaveGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kolicina,
            this.studentImePrezime,
            this.radnikImePrezime});
            this.prijaveGrid.Location = new System.Drawing.Point(12, 97);
            this.prijaveGrid.Name = "prijaveGrid";
            this.prijaveGrid.RowHeadersVisible = false;
            this.prijaveGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prijaveGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prijaveGrid.Size = new System.Drawing.Size(532, 222);
            this.prijaveGrid.TabIndex = 0;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            // 
            // studentImePrezime
            // 
            this.studentImePrezime.DataPropertyName = "studentImePrezime";
            this.studentImePrezime.HeaderText = "Student";
            this.studentImePrezime.Name = "studentImePrezime";
            // 
            // radnikImePrezime
            // 
            this.radnikImePrezime.DataPropertyName = "radnikImePrezime";
            this.radnikImePrezime.HeaderText = "Radnik";
            this.radnikImePrezime.Name = "radnikImePrezime";
            // 
            // studentTxb
            // 
            this.studentTxb.Location = new System.Drawing.Point(16, 47);
            this.studentTxb.Name = "studentTxb";
            this.studentTxb.Size = new System.Drawing.Size(100, 20);
            this.studentTxb.TabIndex = 1;
            // 
            // radnikTxb
            // 
            this.radnikTxb.Location = new System.Drawing.Point(136, 47);
            this.radnikTxb.Name = "radnikTxb";
            this.radnikTxb.Size = new System.Drawing.Size(100, 20);
            this.radnikTxb.TabIndex = 2;
            // 
            // kolicinaTxb
            // 
            this.kolicinaTxb.Location = new System.Drawing.Point(260, 47);
            this.kolicinaTxb.Name = "kolicinaTxb";
            this.kolicinaTxb.Size = new System.Drawing.Size(100, 20);
            this.kolicinaTxb.TabIndex = 3;
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(378, 45);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(75, 23);
            this.traziBtn.TabIndex = 4;
            this.traziBtn.Text = "Trazi";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Radnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Količina";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentTxb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radnikTxb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kolicinaTxb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.traziBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // EntryRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prijaveGrid);
            this.Name = "EntryRecords";
            this.Text = "Prijave";
            this.Load += new System.EventHandler(this.EntryRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prijaveGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView prijaveGrid;
		private System.Windows.Forms.TextBox studentTxb;
		private System.Windows.Forms.TextBox radnikTxb;
		private System.Windows.Forms.TextBox kolicinaTxb;
		private System.Windows.Forms.Button traziBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentImePrezime;
		private System.Windows.Forms.DataGridViewTextBoxColumn radnikImePrezime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
	}
}