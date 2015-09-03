using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FITBiD.DA;

namespace FITBiD.Forms
{
    public partial class BookSale : Form
    {
        DSKnjige.KnjigaPretragaDataTable knjige = new DSKnjige.KnjigaPretragaDataTable();
        int id = new int();
        public BookSale()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookSale_Load(object sender, EventArgs e)
        {
           // DAKnjige.KnjigaSearch(knjige, null, null);
            //dataGridView1.DataSource = knjige;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DA.DAKnjige.SaleKnjiga(id);
            MessageBox.Show("Prodaja knjige uspješno evidentirana!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // DA.DAKnjige.KnjigaSearch(knjige, nazivKnjiga.Text, null);
            //dataGridView1.DataSource = knjige;

        }
    }
}
