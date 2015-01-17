namespace FITBiD.Forms {
	partial class AddWorker {
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(84, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ime";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Prezime";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Username";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(55, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Password";
			// 
			// txtIme
			// 
			this.txtIme.Location = new System.Drawing.Point(139, 61);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(141, 20);
			this.txtIme.TabIndex = 5;
			// 
			// txtPrezime
			// 
			this.txtPrezime.Location = new System.Drawing.Point(139, 95);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(141, 20);
			this.txtPrezime.TabIndex = 6;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(139, 131);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(141, 20);
			this.txtEmail.TabIndex = 7;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(139, 166);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(141, 20);
			this.txtUsername.TabIndex = 8;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(139, 203);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(141, 20);
			this.txtPassword.TabIndex = 9;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(209, 249);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(128, 249);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// AddWorker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 308);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPrezime);
			this.Controls.Add(this.txtIme);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddWorker";
			this.Text = "AddWorker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtIme;
		private System.Windows.Forms.TextBox txtPrezime;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
	}
}