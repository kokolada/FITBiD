﻿namespace FITBiD {
	partial class Menu {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listOfStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listOfWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.workersToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfStudentsToolStripMenuItem});
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.reportsToolStripMenuItem.Text = "Reports";
			// 
			// listOfStudentsToolStripMenuItem
			// 
			this.listOfStudentsToolStripMenuItem.Name = "listOfStudentsToolStripMenuItem";
			this.listOfStudentsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.listOfStudentsToolStripMenuItem.Text = "List of students";
			this.listOfStudentsToolStripMenuItem.Click += new System.EventHandler(this.listOfStudentsToolStripMenuItem_Click);
			// 
			// workersToolStripMenuItem
			// 
			this.workersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfWorkersToolStripMenuItem,
            this.addWorkerToolStripMenuItem});
			this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
			this.workersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.workersToolStripMenuItem.Text = "Workers";
			this.workersToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
			// 
			// listOfWorkersToolStripMenuItem
			// 
			this.listOfWorkersToolStripMenuItem.Name = "listOfWorkersToolStripMenuItem";
			this.listOfWorkersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.listOfWorkersToolStripMenuItem.Text = "List of workers";
			this.listOfWorkersToolStripMenuItem.Click += new System.EventHandler(this.listOfWorkersToolStripMenuItem_Click);
			// 
			// addWorkerToolStripMenuItem
			// 
			this.addWorkerToolStripMenuItem.Name = "addWorkerToolStripMenuItem";
			this.addWorkerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.addWorkerToolStripMenuItem.Text = "Add worker";
			this.addWorkerToolStripMenuItem.Click += new System.EventHandler(this.addWorkerToolStripMenuItem_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Menu";
			this.Text = "Menu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listOfStudentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listOfWorkersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addWorkerToolStripMenuItem;
	}
}