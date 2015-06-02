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

namespace FITBiD.Forms {
	public partial class KeysRecord : Form {
		DSEvidencijaKljucevaV2 dsEvidencija = new DSEvidencijaKljucevaV2();
		public KeysRecord() {
			InitializeComponent();

			//nastavno osoblje
			DANastavnoOsoblje.GetAllOsoblje(dsEvidencija.NastavnoOsobljes);
			DSEvidencijaKljucevaV2.NastavnoOsobljesRow osoblje = dsEvidencija.NastavnoOsobljes.NewNastavnoOsobljesRow();
			osoblje.Id = 0;
			dsEvidencija.NastavnoOsobljes.Rows.InsertAt(osoblje, 0);
			cbxOsoblje.DataSource = dsEvidencija.NastavnoOsobljes;
			cbxOsoblje.DisplayMember = "ImePrezime";
			cbxOsoblje.ValueMember = "Id";

			//ucionica
			DAKljucevi.GetAllKljucevi(dsEvidencija.Kljucs);
			DSEvidencijaKljucevaV2.KljucsRow kljuc = dsEvidencija.Kljucs.NewKljucsRow();
			cbxKljuc.DataSource = dsEvidencija.Kljucs;
			cbxKljuc.DisplayMember = "Barcode";
			cbxKljuc.ValueMember = "Id";


			//na osnovu učionice preuzeti ključId i dodati u bazu
			
		}

		private void button1_Click(object sender, EventArgs e) {	
			DAEvidencijaKljuceva.EvidentirajKljuc(datumPreuzimanja.Value.Date, datumVracanja.Value.Date, Convert.ToInt32(cbxKljuc.SelectedValue), Convert.ToInt32(cbxOsoblje.SelectedValue));
			MessageBox.Show("Uspješno ste evidentirali kljuc", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);	
		}



	}
}
