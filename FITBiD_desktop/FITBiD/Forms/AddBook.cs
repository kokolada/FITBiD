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
	public partial class AddBook : Form
	{
		public AddBook()
		{
			InitializeComponent();
		}

		private void btnPonisti_Click(object sender, EventArgs e)
		{
			txtAutor.Text = "";
			txtBarcode.Text = "";
			txtCijena.Text = "";
			txtGodinaObjavljivanja.Text = "";
			txtNaziv.Text = "";
			txtOznakaStalaze.Text = "";
			cbxZaProdaju.Checked = false;
		}

		private void btnSacuvaj_Click(object sender, EventArgs e)
		{            
			//pozvati proceduru
			if (sveUdure())
			{
                DA.DAKnjige.AddKnjiga(txtAutor.Text, txtBarcode.Text, Convert.ToInt32(txtCijena.Text), Convert.ToInt32(txtGodinaObjavljivanja.Text), txtNaziv.Text, txtOznakaStalaze.Text, cbxZaProdaju.Checked);
				MessageBox.Show("Dodavanje knjige je uspješno izvršeno!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnPonisti_Click(sender, e);
                this.Close();

                Forms.Book frm = new Forms.Book();
                frm.Show();                
			}
		}

		private bool sveUdure()
		{
			return txtAutor.Text != "" && txtBarcode.Text != "" && txtCijena.Text != "" && txtGodinaObjavljivanja.Text != "" && txtNaziv.Text != "" && txtOznakaStalaze.Text != "";
		}

		private void AddBook_Load(object sender, EventArgs e)
		{

		}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCijena_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
