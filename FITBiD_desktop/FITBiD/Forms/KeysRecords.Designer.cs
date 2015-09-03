namespace FITBiD.Forms
{
    partial class KeysRecords
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Preuzimanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vracanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nastavnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucionica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.traziBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucionicaTxb = new System.Windows.Forms.TextBox();
            this.nastavnikTxb = new System.Windows.Forms.TextBox();
            this.datumVracanjaPicker = new System.Windows.Forms.DateTimePicker();
            this.datumPreuzimanjaPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Preuzimanje,
            this.Vracanje,
            this.Nastavnik,
            this.ucionica});
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(481, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // Preuzimanje
            // 
            this.Preuzimanje.DataPropertyName = "preuzimanje";
            this.Preuzimanje.HeaderText = "Preuzimanje";
            this.Preuzimanje.Name = "Preuzimanje";
            this.Preuzimanje.ReadOnly = true;
            // 
            // Vracanje
            // 
            this.Vracanje.DataPropertyName = "vracanje";
            this.Vracanje.HeaderText = "Vraćanje";
            this.Vracanje.Name = "Vracanje";
            this.Vracanje.ReadOnly = true;
            // 
            // Nastavnik
            // 
            this.Nastavnik.DataPropertyName = "ImePrezime";
            this.Nastavnik.HeaderText = "Nastavnik";
            this.Nastavnik.Name = "Nastavnik";
            this.Nastavnik.ReadOnly = true;
            // 
            // ucionica
            // 
            this.ucionica.DataPropertyName = "Naziv";
            this.ucionica.HeaderText = "Učionica";
            this.ucionica.Name = "ucionica";
            this.ucionica.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.traziBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ucionicaTxb);
            this.groupBox1.Controls.Add(this.nastavnikTxb);
            this.groupBox1.Controls.Add(this.datumVracanjaPicker);
            this.groupBox1.Controls.Add(this.datumPreuzimanjaPicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(377, 125);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(75, 23);
            this.traziBtn.TabIndex = 8;
            this.traziBtn.Text = "Traži";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum vraćanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum preuzimanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Učionica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nastavnik";
            // 
            // ucionicaTxb
            // 
            this.ucionicaTxb.Location = new System.Drawing.Point(284, 94);
            this.ucionicaTxb.Name = "ucionicaTxb";
            this.ucionicaTxb.Size = new System.Drawing.Size(168, 20);
            this.ucionicaTxb.TabIndex = 3;
            // 
            // nastavnikTxb
            // 
            this.nastavnikTxb.Location = new System.Drawing.Point(284, 48);
            this.nastavnikTxb.Name = "nastavnikTxb";
            this.nastavnikTxb.Size = new System.Drawing.Size(168, 20);
            this.nastavnikTxb.TabIndex = 2;
            // 
            // datumVracanjaPicker
            // 
            this.datumVracanjaPicker.Location = new System.Drawing.Point(6, 94);
            this.datumVracanjaPicker.Name = "datumVracanjaPicker";
            this.datumVracanjaPicker.Size = new System.Drawing.Size(200, 20);
            this.datumVracanjaPicker.TabIndex = 1;
            // 
            // datumPreuzimanjaPicker
            // 
            this.datumPreuzimanjaPicker.Location = new System.Drawing.Point(6, 48);
            this.datumPreuzimanjaPicker.Name = "datumPreuzimanjaPicker";
            this.datumPreuzimanjaPicker.Size = new System.Drawing.Size(200, 20);
            this.datumPreuzimanjaPicker.TabIndex = 0;
            // 
            // KeysRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KeysRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdati ključevi";
            this.Load += new System.EventHandler(this.KeysRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preuzimanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vracanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nastavnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucionica;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox ucionicaTxb;
		private System.Windows.Forms.TextBox nastavnikTxb;
		private System.Windows.Forms.DateTimePicker datumPreuzimanjaPicker;
		private System.Windows.Forms.Button traziBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker datumVracanjaPicker;
    }
}