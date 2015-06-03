namespace FITBiD.Forms {
	partial class Workers {
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
            this.dgRadnici = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Imetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Prezimetxt = new System.Windows.Forms.TextBox();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Trazibtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRadnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRadnici
            // 
            this.dgRadnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRadnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Email,
            this.Username});
            this.dgRadnici.Location = new System.Drawing.Point(12, 67);
            this.dgRadnici.Name = "dgRadnici";
            this.dgRadnici.ReadOnly = true;
            this.dgRadnici.RowHeadersVisible = false;
            this.dgRadnici.Size = new System.Drawing.Size(405, 232);
            this.dgRadnici.TabIndex = 0;
            this.dgRadnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRadnici_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Korisničko ime";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // Imetxt
            // 
            this.Imetxt.Location = new System.Drawing.Point(13, 38);
            this.Imetxt.Name = "Imetxt";
            this.Imetxt.Size = new System.Drawing.Size(87, 20);
            this.Imetxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // Prezimetxt
            // 
            this.Prezimetxt.Location = new System.Drawing.Point(111, 38);
            this.Prezimetxt.Name = "Prezimetxt";
            this.Prezimetxt.Size = new System.Drawing.Size(85, 20);
            this.Prezimetxt.TabIndex = 4;
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(208, 38);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(100, 20);
            this.Usernametxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Korisničko ime";
            // 
            // Trazibtn
            // 
            this.Trazibtn.Location = new System.Drawing.Point(317, 36);
            this.Trazibtn.Name = "Trazibtn";
            this.Trazibtn.Size = new System.Drawing.Size(100, 23);
            this.Trazibtn.TabIndex = 7;
            this.Trazibtn.Text = "Traži";
            this.Trazibtn.UseVisualStyleBackColor = true;
            this.Trazibtn.Click += new System.EventHandler(this.Trazibtn_Click);
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 310);
            this.Controls.Add(this.Trazibtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.Prezimetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Imetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRadnici);
            this.Name = "Workers";
            this.Text = "Lista radnika";
            this.Load += new System.EventHandler(this.WorkersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRadnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Imetxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Prezimetxt;
		private System.Windows.Forms.TextBox Usernametxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Trazibtn;
        private System.Windows.Forms.DataGridView dgRadnici;
	}
}