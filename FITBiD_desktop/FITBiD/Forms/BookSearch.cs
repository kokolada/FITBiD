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
		public BookSearch()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtNazivKnjige.Text != "" && txtAutor.Text != "")
			{
				gridPretraga.DataSource = DA.DAKnjige.KnjigaSearch(txtNazivKnjige.Text, txtAutor.Text);
			}
		}

		private void BookSearch_Load(object sender, EventArgs e)
		{
			gridPretraga.DataSource = DA.DAKnjige.KnjigaSearch(null, null);
		}
	}
}
