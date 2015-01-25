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
	public partial class Workers : Form {

		DSRadinici.RadniksDataTable dtRadnici = new DSRadinici.RadniksDataTable();

		public Workers() {
			InitializeComponent();
		}

		private void WorkersList_Load(object sender, EventArgs e) {
			
			DARadnici.getRadnici(dtRadnici);
			dgRadnici.AutoGenerateColumns = false;
			dgRadnici.DataSource = dtRadnici;			
		}

		private void Trazibtn_Click(object sender, EventArgs e) {
			DARadnici.getRadniciByNLU(dtRadnici,Imetxt.Text,Prezimetxt.Text,Usernametxt.Text);

			dgRadnici.DataSource = dtRadnici;
		}

	}
}
