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
		DSEvidencijaKljuceva dsEvidencija = new DSEvidencijaKljuceva();
		public KeysRecord() {
			InitializeComponent();

			//nastavno osoblje
			DANastavnoOsoblje.GetAllOsoblje(dsEvidencija.NastavnoOsobljes);
			DSEvidencijaKljuceva.NastavnoOsobljesRow osoblje = dsEvidencija.NastavnoOsobljes.NewNastavnoOsobljesRow();
			osoblje.Id = 0;
			dsEvidencija.NastavnoOsobljes.Rows.InsertAt(osoblje, 0);
			cbxOsoblje.DataSource = dsEvidencija.NastavnoOsobljes;
			cbxOsoblje.DisplayMember = "ImePrezime";
			cbxOsoblje.ValueMember = "Id";

			//ucionica
			DAUcionice.GetAllUcionice(dsEvidencija.Ucionicas);
			DSEvidencijaKljuceva.UcionicasRow ucionica = dsEvidencija.Ucionicas.NewUcionicasRow();
			ucionica.Id = 0;
			dsEvidencija.Ucionicas.Rows.InsertAt(ucionica, 0);
			cbxKljuc.DataSource = dsEvidencija.Ucionicas;
			cbxKljuc.DisplayMember = "Naziv";
			cbxKljuc.ValueMember = "Id";

			//radnici
			DARadnici.getRadnici(dsEvidencija.Radniks);
			DSEvidencijaKljuceva.RadniksRow radnik = dsEvidencija.Radniks.NewRadniksRow();
			radnik.Id = 0;
			dsEvidencija.Radniks.Rows.InsertAt(radnik, 0);
			cbxRadnik.DataSource = dsEvidencija.Radniks;
			cbxRadnik.DisplayMember = "Ime";
			cbxRadnik.ValueMember = "Id";

			//na osnovu učionice preuzeti ključId i dodati u bazu
			
		}

		private void button1_Click(object sender, EventArgs e) {

			
		}

	}
}
