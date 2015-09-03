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

        DSKnjige.KnjigaPretragaDataTable dtKnjige = new DSKnjige.KnjigaPretragaDataTable();
		public BookSearch()
		{
			InitializeComponent();          
		}

		private void button1_Click(object sender, EventArgs e)
		{
            if (cbxProdaja.Checked)
                BindGrid(false);
            else
                BindGrid(true);        
		}

		private void BookSearch_Load(object sender, EventArgs e)
		{
            BindGrid(true);
		}

        private void BindGrid(bool firstCall)
        {
            string naziv = txtKnjiga.Text; string autor = txtAutorrr.Text; string barcode = txtBarcode.Text;
            bool check = cbxProdaja.Checked;

            int min = 0; Int32.TryParse(txtMin.Text, out min);
            int max = 0; Int32.TryParse(txtMax.Text, out max);


            DA.DAKnjige.KnjigeSearch(dtKnjige, naziv, autor, barcode, check, min, max, firstCall);

            dgPretraga.AutoGenerateColumns = false;
            dgPretraga.DataSource = dtKnjige;
            txtBroj.Text = dtKnjige.Count.ToString();
        }

		private void gridPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgPretraga_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(dgPretraga.SelectedRows[0].Cells[0].Value);
            string naziv = dgPretraga.SelectedRows[0].Cells[1].Value.ToString();
            Forms.BookDetails frm = new BookDetails(id,naziv);
            frm.Show();
        }
	}
}
