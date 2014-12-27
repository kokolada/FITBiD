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
			this.SuspendLayout();
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelUsername.Location = new System.Drawing.Point(50, 46);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(88, 20);
			this.labelUsername.TabIndex = 0;
			this.labelUsername.Text = "username: ";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelPassword.Location = new System.Drawing.Point(50, 74);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(85, 20);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "password: ";
			// 
			// loginUsername
			// 
			this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loginUsername.Location = new System.Drawing.Point(144, 37);
			this.loginUsername.Name = "loginUsername";
			this.loginUsername.Size = new System.Drawing.Size(183, 29);
			this.loginUsername.TabIndex = 2;
			// 
			// loginPassword
			// 
			this.loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loginPassword.Location = new System.Drawing.Point(144, 74);
			this.loginPassword.Name = "loginPassword";
			this.loginPassword.Size = new System.Drawing.Size(183, 29);
			this.loginPassword.TabIndex = 3;
			// 
			// loginSubmit
			// 
			this.loginSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loginSubmit.Location = new System.Drawing.Point(144, 124);
			this.loginSubmit.Name = "loginSubmit";
			this.loginSubmit.Size = new System.Drawing.Size(183, 31);
			this.loginSubmit.TabIndex = 4;
			this.loginSubmit.Text = "LOGIN";
			this.loginSubmit.UseVisualStyleBackColor = true;
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 177);
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
	}
}

