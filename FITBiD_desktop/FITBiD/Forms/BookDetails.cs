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
    public partial class BookDetails : Form
    {
        DA.DSKnjige.KnjigaPretragaDataTable dtKnjiga = new DA.DSKnjige.KnjigaPretragaDataTable();
        DA.DSKnjige.IznajmljivanjeDataTable dtIznajmljivanja = new DA.DSKnjige.IznajmljivanjeDataTable();
        DA.DSKnjige.RezervacijeDataTable dtRezervacije = new DA.DSKnjige.RezervacijeDataTable();
        int KnjigaId;
        string KnjigaNaziv;
        public BookDetails(int knjigaId, string naziv)
        {
            InitializeComponent();
            KnjigaId = knjigaId;
            KnjigaNaziv = naziv;
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            DA.DAKnjige.KnjigeSearch(dtKnjiga, KnjigaNaziv, "", "", false, 0, 0, true);
            txtNaziv.Text = dtKnjiga[0].Naziv;
            txtAutor.Text = dtKnjiga[0].Autor;
            txtBarcode.Text = dtKnjiga[0].Barcode;
            txtGodina.Text = dtKnjiga[0].GodinaObjavljivanja;
            txtProdaja.Text = dtKnjiga[0].ZaProdaju;
            txtCijena.Text = dtKnjiga[0].Cijena + " KM";
            txtStalaza.Text = dtKnjiga[0].OznakaStalaze;

            DA.DAKnjige.GetRezervacijeKnjigeById(dtRezervacije, KnjigaId);
            dgRezervacije.AutoGenerateColumns = false;
            dgRezervacije.DataSource = dtRezervacije;
            txtRezervisano.Text = dtRezervacije.Count.ToString();

            DA.DAKnjige.GetIznajmljivanjeKnjigeById(dtIznajmljivanja, KnjigaId);
            dgIznajmljivanja.AutoGenerateColumns = false;
            dgIznajmljivanja.DataSource = dtIznajmljivanja;
            txtxIznajmljeno.Text = dtIznajmljivanja.Count.ToString();
        }
    }
}
