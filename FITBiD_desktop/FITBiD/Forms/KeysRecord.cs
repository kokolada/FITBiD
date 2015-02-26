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
			DANastavnoOsoblje.GetAllOsoblje(dsEvidencija.NastavnoOsobljes);

			DSEvidencijaKljuceva.NastavnoOsobljesRow osoblje = dsEvidencija.NastavnoOsobljes.NewNastavnoOsobljesRow();

			osoblje.Id = 0;
			dsEvidencija.NastavnoOsobljes.Rows.InsertAt(osoblje, 0);


			cbxOsoblje.DataSource = dsEvidencija.NastavnoOsobljes;
			cbxOsoblje.DisplayMember = "ImePrezime";
			cbxOsoblje.ValueMember = "Id";

		}

	}
}
