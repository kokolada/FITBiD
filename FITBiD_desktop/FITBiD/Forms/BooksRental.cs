using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITBiD.Forms {
	public partial class BooksRental : Form {
		DA.DSEvidencijaIznajmljivanjaKnjiga.EvidencijaKnjigaZaIznajmljivanjesDataTable iznajmljeneKnjige =  new DA.DSEvidencijaIznajmljivanjaKnjiga.EvidencijaKnjigaZaIznajmljivanjesDataTable();
		public BooksRental() {
			InitializeComponent();
			iznajmljeneKnjigeGrid.AutoGenerateColumns = false;
		}

		private void BooksRental_Load(object sender, EventArgs e) {
			DA.DAEvidencijaIznajmljivanja.GetEvidencijeIznajmljivanja(iznajmljeneKnjige);
			iznajmljeneKnjigeGrid.DataSource = iznajmljeneKnjige;
		}

		private void traziBtn_Click(object sender, EventArgs e) {
			DA.DAEvidencijaIznajmljivanja.GetEvidencijaIznajmljivanjaByDKRS(iznajmljeneKnjige,datumIzdavanjaPicker.Value.Date,datumVracanjaPicker.Value.Date,knjigaTxb.Text,radnikTxb.Text,studentTxb.Text);
			iznajmljeneKnjigeGrid.DataSource = iznajmljeneKnjige;
		}
	}
}
