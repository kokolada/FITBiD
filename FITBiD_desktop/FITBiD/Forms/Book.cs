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
    public partial class Book : Form
    {
        DSKnjige.KnjigasDataTable knjiga = new DSKnjige.KnjigasDataTable();

        public Book()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {
            DA.DAKnjige.getLastAddedBook(knjiga);
            txtAutor.Text = knjiga[0].Autor;
            txtNaziv.Text = knjiga[0].Naziv;
            txtGodina.Text = knjiga[0].GodinaObjavljivanja.Year.ToString();
            txtBarcode.Text = knjiga[0].Barcode;
            txtStalaza.Text = knjiga[0].OznakaStalaze;
            if (knjiga[0].Cijena >= 0 )
                txtCijena.Text = knjiga[0].Cijena.ToString();
            else
                txtCijena.Text = "0";

            if(knjiga[0].ZaProdaju == true)
                prodaja.Checked = true;
            else prodaja.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
