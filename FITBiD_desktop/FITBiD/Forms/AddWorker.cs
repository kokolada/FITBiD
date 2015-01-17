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

namespace FITBiD.Forms {
	public partial class AddWorker : Form {
		public AddWorker() {
			InitializeComponent();
		}
		private void btnSave_Click(object sender, EventArgs e) {
			DARadnici.InsertRadnik(txtIme.Text,txtPrezime.Text,txtEmail.Text,txtUsername.Text,txtPassword.Text);
			/*dodati validaciju i obavijest o uspješnosti*/
		}

		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
