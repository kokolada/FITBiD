namespace FITBiD.Forms
{
    partial class LoginLogs
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
            this.txtRadnik = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgRadnici = new System.Windows.Forms.DataGridView();
            this.loginRadnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Radnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgStudenti = new System.Windows.Forms.DataGridView();
            this.loginStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumLogina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtManagement = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgManagement = new System.Windows.Forms.DataGridView();
            this.loginManagementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenadzmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menadzemnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRadnici)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudenti)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRadnik);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(6, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // txtRadnik
            // 
            this.txtRadnik.Location = new System.Drawing.Point(98, 24);
            this.txtRadnik.Name = "txtRadnik";
            this.txtRadnik.Size = new System.Drawing.Size(117, 20);
            this.txtRadnik.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pretraga";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radnik";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgRadnici);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 295);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logiranja radnika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "* Dupli klik otvara detaljnije informacije";
            // 
            // dgRadnici
            // 
            this.dgRadnici.AllowUserToAddRows = false;
            this.dgRadnici.AllowUserToDeleteRows = false;
            this.dgRadnici.AllowUserToResizeColumns = false;
            this.dgRadnici.AllowUserToResizeRows = false;
            this.dgRadnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRadnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRadnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginRadnikId,
            this.RadnikId,
            this.Datum,
            this.Radnik});
            this.dgRadnici.Location = new System.Drawing.Point(6, 125);
            this.dgRadnici.MultiSelect = false;
            this.dgRadnici.Name = "dgRadnici";
            this.dgRadnici.ReadOnly = true;
            this.dgRadnici.RowHeadersVisible = false;
            this.dgRadnici.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgRadnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRadnici.Size = new System.Drawing.Size(221, 164);
            this.dgRadnici.TabIndex = 1;
            this.dgRadnici.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRadnici_CellContentDoubleClick);
            // 
            // loginRadnikId
            // 
            this.loginRadnikId.DataPropertyName = "Id";
            this.loginRadnikId.HeaderText = "id";
            this.loginRadnikId.Name = "loginRadnikId";
            this.loginRadnikId.ReadOnly = true;
            this.loginRadnikId.Visible = false;
            // 
            // RadnikId
            // 
            this.RadnikId.DataPropertyName = "RadnikId";
            this.RadnikId.HeaderText = "RadnikId";
            this.RadnikId.Name = "RadnikId";
            this.RadnikId.ReadOnly = true;
            this.RadnikId.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumLogina";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Radnik
            // 
            this.Radnik.DataPropertyName = "Radnik";
            this.Radnik.HeaderText = "Radnik";
            this.Radnik.Name = "Radnik";
            this.Radnik.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStudent);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(6, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 84);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraga";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(109, 23);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(100, 20);
            this.txtStudent.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pretraga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.dgStudenti);
            this.groupBox4.Location = new System.Drawing.Point(251, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 295);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logiranja studenata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "* Dupli klik otvara detaljnije informacije";
            // 
            // dgStudenti
            // 
            this.dgStudenti.AllowUserToAddRows = false;
            this.dgStudenti.AllowUserToDeleteRows = false;
            this.dgStudenti.AllowUserToResizeColumns = false;
            this.dgStudenti.AllowUserToResizeRows = false;
            this.dgStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginStudentId,
            this.StudentId,
            this.DatumLogina,
            this.Student});
            this.dgStudenti.Location = new System.Drawing.Point(6, 125);
            this.dgStudenti.MultiSelect = false;
            this.dgStudenti.Name = "dgStudenti";
            this.dgStudenti.ReadOnly = true;
            this.dgStudenti.RowHeadersVisible = false;
            this.dgStudenti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudenti.Size = new System.Drawing.Size(215, 164);
            this.dgStudenti.TabIndex = 0;
            this.dgStudenti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStudenti_CellContentDoubleClick);
            // 
            // loginStudentId
            // 
            this.loginStudentId.DataPropertyName = "Id";
            this.loginStudentId.HeaderText = "Id";
            this.loginStudentId.Name = "loginStudentId";
            this.loginStudentId.ReadOnly = true;
            this.loginStudentId.Visible = false;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // DatumLogina
            // 
            this.DatumLogina.DataPropertyName = "DatumLogina";
            this.DatumLogina.HeaderText = "Datum";
            this.DatumLogina.Name = "DatumLogina";
            this.DatumLogina.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtManagement);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(6, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 84);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pretraga";
            // 
            // txtManagement
            // 
            this.txtManagement.Location = new System.Drawing.Point(107, 23);
            this.txtManagement.Name = "txtManagement";
            this.txtManagement.Size = new System.Drawing.Size(100, 20);
            this.txtManagement.TabIndex = 0;
            this.txtManagement.TextChanged += new System.EventHandler(this.txtManagement_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Pretraga";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menadžment";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.dgManagement);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Location = new System.Drawing.Point(484, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(227, 295);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Logiranja menadžmenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "* Dupli klik otvara detaljnije informacije";
            // 
            // dgManagement
            // 
            this.dgManagement.AllowUserToAddRows = false;
            this.dgManagement.AllowUserToDeleteRows = false;
            this.dgManagement.AllowUserToResizeColumns = false;
            this.dgManagement.AllowUserToResizeRows = false;
            this.dgManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginManagementId,
            this.MenadzmentId,
            this.DatumLogin,
            this.Menadzemnt});
            this.dgManagement.Location = new System.Drawing.Point(6, 125);
            this.dgManagement.MultiSelect = false;
            this.dgManagement.Name = "dgManagement";
            this.dgManagement.ReadOnly = true;
            this.dgManagement.RowHeadersVisible = false;
            this.dgManagement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgManagement.Size = new System.Drawing.Size(215, 164);
            this.dgManagement.TabIndex = 0;
            this.dgManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManagement_CellContentClick);
            this.dgManagement.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManagement_CellContentDoubleClick);
            // 
            // loginManagementId
            // 
            this.loginManagementId.HeaderText = "Id";
            this.loginManagementId.Name = "loginManagementId";
            this.loginManagementId.ReadOnly = true;
            this.loginManagementId.Visible = false;
            // 
            // MenadzmentId
            // 
            this.MenadzmentId.DataPropertyName = "MenadzmentId";
            this.MenadzmentId.HeaderText = "MenadzmentId";
            this.MenadzmentId.Name = "MenadzmentId";
            this.MenadzmentId.ReadOnly = true;
            this.MenadzmentId.Visible = false;
            // 
            // DatumLogin
            // 
            this.DatumLogin.DataPropertyName = "DatumLogina";
            this.DatumLogin.HeaderText = "Datum";
            this.DatumLogin.Name = "DatumLogin";
            this.DatumLogin.ReadOnly = true;
            // 
            // Menadzemnt
            // 
            this.Menadzemnt.DataPropertyName = "Menadzemnt";
            this.Menadzemnt.HeaderText = "Menadžment";
            this.Menadzemnt.Name = "Menadzemnt";
            this.Menadzemnt.ReadOnly = true;
            // 
            // LoginLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Name = "LoginLogs";
            this.Text = "Login logs";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRadnici)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudenti)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRadnik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgRadnici;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgStudenti;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtManagement;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgManagement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginRadnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumLogina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginManagementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenadzmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menadzemnt;
    }
}