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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Preuzimanje,
            this.Vracanje,
            this.Nastavnik,
            this.ucionica});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 211);
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
            // KeysRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 244);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KeysRecords";
            this.Text = "Izdati ključevi";
            this.Load += new System.EventHandler(this.KeysRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preuzimanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vracanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nastavnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucionica;
    }
}