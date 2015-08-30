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
	public partial class EntryRecords : Form {
		
		DA.DSEvidencijaPrijava.EvidencijaPrijavasDataTable prijave = new DA.DSEvidencijaPrijava.EvidencijaPrijavasDataTable();
		public EntryRecords() {
			InitializeComponent();
			prijaveGrid.AutoGenerateColumns = false;
		}

		private void EntryRecords_Load(object sender, EventArgs e) {
			DA.DAEvidencijaPrijava.GetEvidencijaPrijava(prijave);
			prijaveGrid.DataSource = prijave;

		}
		private void traziBtn_Click(object sender, EventArgs e) {
			
		}
	}
}
