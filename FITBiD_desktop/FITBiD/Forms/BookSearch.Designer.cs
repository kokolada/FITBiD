namespace FITBiD.Forms
{
	partial class BookSearch
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dSKnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSKnjige = new FITBiD.DA.DSKnjige();
            this.gridDetalji = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaObjavljivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OznakaStalaze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaProdaju = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPretraga = new System.Windows.Forms.DataGridView();
            this.knjigaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigaGodina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjigeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Knjiga";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNazivKnjige
            // 
            this.txtNazivKnjige.Location = new System.Drawing.Point(55, 10);
            this.txtNazivKnjige.Name = "txtNazivKnjige";
            this.txtNazivKnjige.Size = new System.Drawing.Size(117, 20);
            this.txtNazivKnjige.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(216, 10);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(122, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(344, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pretraga";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dSKnjigeBindingSource
            // 
            this.dSKnjigeBindingSource.DataSource = this.dSKnjige;
            this.dSKnjigeBindingSource.Position = 0;
            // 
            // dSKnjige
            // 
            this.dSKnjige.DataSetName = "DSKnjige";
            this.dSKnjige.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridDetalji
            // 
            this.gridDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.GodinaObjavljivanja,
            this.Autor,
            this.Barcode,
            this.OznakaStalaze,
            this.ZaProdaju,
            this.Cijena});
            this.gridDetalji.Location = new System.Drawing.Point(16, 196);
            this.gridDetalji.Name = "gridDetalji";
            this.gridDetalji.ReadOnly = true;
            this.gridDetalji.RowHeadersVisible = false;
            this.gridDetalji.Size = new System.Drawing.Size(704, 45);
            this.gridDetalji.TabIndex = 6;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // GodinaObjavljivanja
            // 
            this.GodinaObjavljivanja.DataPropertyName = "GodinaObjavljivanja";
            this.GodinaObjavljivanja.HeaderText = "Izdana";
            this.GodinaObjavljivanja.Name = "GodinaObjavljivanja";
            this.GodinaObjavljivanja.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // OznakaStalaze
            // 
            this.OznakaStalaze.DataPropertyName = "OznakaStalaze";
            this.OznakaStalaze.HeaderText = "Stalaža";
            this.OznakaStalaze.Name = "OznakaStalaze";
            this.OznakaStalaze.ReadOnly = true;
            // 
            // ZaProdaju
            // 
            this.ZaProdaju.DataPropertyName = "ZaProdaju";
            this.ZaProdaju.HeaderText = "Prodaja";
            this.ZaProdaju.Name = "ZaProdaju";
            this.ZaProdaju.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena (KM) ";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cijena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridPretraga
            // 
            this.gridPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjigaNaziv,
            this.knjigaGodina,
            this.knjigaAutor,
            this.knjigaCijena});
            this.gridPretraga.Location = new System.Drawing.Point(16, 36);
            this.gridPretraga.Name = "gridPretraga";
            this.gridPretraga.ReadOnly = true;
            this.gridPretraga.RowHeadersVisible = false;
            this.gridPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPretraga.Size = new System.Drawing.Size(704, 150);
            this.gridPretraga.TabIndex = 7;
            this.gridPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPretraga_CellContentClick);
            // 
            // knjigaNaziv
            // 
            this.knjigaNaziv.DataPropertyName = "Naziv";
            this.knjigaNaziv.HeaderText = "Naziv";
            this.knjigaNaziv.Name = "knjigaNaziv";
            this.knjigaNaziv.ReadOnly = true;
            // 
            // knjigaGodina
            // 
            this.knjigaGodina.DataPropertyName = "GodinaObjavljivanja";
            this.knjigaGodina.HeaderText = "Izdana";
            this.knjigaGodina.Name = "knjigaGodina";
            this.knjigaGodina.ReadOnly = true;
            // 
            // knjigaAutor
            // 
            this.knjigaAutor.DataPropertyName = "Autor";
            this.knjigaAutor.HeaderText = "Autor";
            this.knjigaAutor.Name = "knjigaAutor";
            this.knjigaAutor.ReadOnly = true;
            // 
            // knjigaCijena
            // 
            this.knjigaCijena.DataPropertyName = "Cijena";
            this.knjigaCijena.HeaderText = "Cijena";
            this.knjigaCijena.Name = "knjigaCijena";
            this.knjigaCijena.ReadOnly = true;
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 253);
            this.Controls.Add(this.gridPretraga);
            this.Controls.Add(this.gridDetalji);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazivKnjige);
            this.Controls.Add(this.label1);
            this.Name = "BookSearch";
            this.Text = "BookSearch";
            this.Load += new System.EventHandler(this.BookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjigeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKnjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNazivKnjige;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridView gridDetalji;
		private System.Windows.Forms.BindingSource dSKnjigeBindingSource;
		private DA.DSKnjige dSKnjige;
        private System.Windows.Forms.DataGridView gridPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaGodina;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaObjavljivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OznakaStalaze;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ZaProdaju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
	}
}