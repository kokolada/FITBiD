using FITBiD.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITBiD.Forms
{
	public partial class BookSearch : Form
	{

		DSKnjige.KnjigasDataTable knjige = new DSKnjige.KnjigasDataTable();
		DSKnjige.KnjigasDataTable selectekKnjiga = new DSKnjige.KnjigasDataTable();
		public BookSearch()
		{
			InitializeComponent();
			gridPretraga.AutoGenerateColumns = false;
			gridDetalji.AutoGenerateColumns = false;            
		}

		private void button1_Click(object sender, EventArgs e)
		{			
			DA.DAKnjige.KnjigaSearch(knjige, txtNazivKnjige.Text, txtAutor.Text);
			gridPretraga.DataSource = knjige;
			
		}

		private void BookSearch_Load(object sender, EventArgs e)
		{
			DA.DAKnjige.KnjigaSearch(knjige, null, null);
			gridPretraga.DataSource = knjige;
		}

		private void gridPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			selectekKnjiga.Clear();
			string Naziv = gridPretraga.SelectedRows[0].Cells[0].Value.ToString();
			DA.DAKnjige.KnjigaSearch(selectekKnjiga, Naziv, null);
			gridDetalji.DataSource = selectekKnjiga;
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
	}
}
