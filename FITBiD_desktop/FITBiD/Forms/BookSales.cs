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
    public partial class BookSales : Form
    {
        DA.DSEvidencijaProdaje.EvidencijaKnjigaZaProdajusDataTable dt = new DA.DSEvidencijaProdaje.EvidencijaKnjigaZaProdajusDataTable();
        public BookSales()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = DA.DAKnjige.getProdateKnjigeByNaziv(dt, nazivKnjige.Text);                
        }

        private void BookSale_Load(object sender, EventArgs e)
        {

            dataGridView.DataSource = DA.DAKnjige.getProdateKnjige(dt);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
