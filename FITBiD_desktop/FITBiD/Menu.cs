using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITBiD {
	public partial class Menu : Form {
		public Menu() {
			InitializeComponent();
		}

		private void listOfStudentsToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports();
			frm.Show();
		}

		private void workerToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.AddWorker frm = new Forms.AddWorker();
			frm.Show();

		}
	}
}
