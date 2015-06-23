namespace FITBiD
{
	partial class Start
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
			this.labelUsername = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.loginUsername = new System.Windows.Forms.TextBox();
			this.loginPassword = new System.Windows.Forms.TextBox();
			this.loginSubmit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblGreska = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelUsername.Location = new System.Drawing.Point(12, 46);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(73, 17);
			this.labelUsername.TabIndex = 0;
			this.labelUsername.Text = "Username";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelPassword.Location = new System.Drawing.Point(12, 89);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(69, 17);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "Password";
			// 
			// loginUsername
			// 
			this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loginUsername.Location = new System.Drawing.Point(106, 40);
			this.loginUsername.Name = "loginUsername";
			this.loginUsername.Size = new System.Drawing.Size(199, 29);
			this.loginUsername.TabIndex = 2;
			// 
			// loginPassword
			// 
			this.loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loginPassword.Location = new System.Drawing.Point(106, 83);
			this.loginPassword.Name = "loginPassword";
			this.loginPassword.PasswordChar = '*';
			this.loginPassword.Size = new System.Drawing.Size(198, 29);
			this.loginPassword.TabIndex = 3;
			this.loginPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginPassword_KeyPress);
			// 
			// loginSubmit
			// 
			this.loginSubmit.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.loginSubmit.Location = new System.Drawing.Point(222, 118);
			this.loginSubmit.Name = "loginSubmit";
			this.loginSubmit.Size = new System.Drawing.Size(83, 30);
			this.loginSubmit.TabIndex = 4;
			this.loginSubmit.Text = "Login";
			this.loginSubmit.UseVisualStyleBackColor = true;
			this.loginSubmit.Click += new System.EventHandler(this.loginSubmit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(103, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Molimo unesite vaš username i password!";
			// 
			// lblGreska
			// 
			this.lblGreska.AutoSize = true;
			this.lblGreska.ForeColor = System.Drawing.Color.Crimson;
			this.lblGreska.Location = new System.Drawing.Point(103, 117);
			this.lblGreska.Name = "lblGreska";
			this.lblGreska.Size = new System.Drawing.Size(108, 13);
			this.lblGreska.TabIndex = 6;
			this.lblGreska.Text = "Pogrešni login podaci";
			this.lblGreska.Visible = false;
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 177);
			this.Controls.Add(this.lblGreska);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loginSubmit);
			this.Controls.Add(this.loginPassword);
			this.Controls.Add(this.loginUsername);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelUsername);
			this.Name = "Start";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox loginUsername;
		private System.Windows.Forms.TextBox loginPassword;
		private System.Windows.Forms.Button loginSubmit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblGreska;
	}
}

