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
			Forms.Reports frm = new Forms.Reports("students");
			frm.MdiParent = this;
			frm.Show();
		}

		private void workersToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

		private void addWorkerToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.AddWorker frm = new Forms.AddWorker();
			frm.MdiParent = this;

			frm.Show();
		}

		private void listOfWorkersToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Workers frm = new Forms.Workers();
			frm.MdiParent = this;
			frm.Show();
		}

		private void KeysRecordToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("izdavanjeKljuceva");
			frm.MdiParent = this;
			frm.Show();
		}

		private void booksRecordToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("izdavanjeKnjiga");
			frm.MdiParent = this;
			frm.Show();
		}

		private void mostActiveStudentsToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najaktivnijiStudenti");
			frm.MdiParent = this;
			frm.Show();
		}

		private void bestWorkersToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najboljiRadnici");
			frm.MdiParent = this;
			frm.Show();
		}

		private void materialUseToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("potrosnjaMaterijala");
			frm.MdiParent = this;
			frm.Show();
		}

		private void booksSalesToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("prodajaKnjiga");
			frm.MdiParent = this;
			frm.Show();
		}

		private void mostActiveStudentToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najaktivnijiStudent");
			frm.MdiParent = this;
			frm.Show();
		}

		private void mostActiveStudentOnSystemToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najaktivnijiStudentPoLoginu");
			frm.MdiParent = this;
			frm.Show();
		}

		private void mostPopulatedCategoryToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najzastupljenijeKategorije");
			frm.MdiParent = this;
			frm.Show();
		}
		private void materialsRecordToolStripMenuItem_Click(object sender, EventArgs e) {
			Reports.LocalReport frm = new Reports.LocalReport();
			frm.MdiParent = this;
			frm.Show();
		}


		private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Forms.AddBook frm = new Forms.AddBook();
			frm.MdiParent = this;
			frm.Show();
		}

		private void recordToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.KeysRecord frm = new Forms.KeysRecord();
			frm.MdiParent = this;
			frm.Show();
		}

		private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Forms.BookSearch frm = new Forms.BookSearch();
			frm.MdiParent = this;
			frm.Show();
		}

        private void prodaneKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BookSales frm = new Forms.BookSales();
			frm.MdiParent = this;
            frm.Show();
        }

        private void prodajKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BookSale frm = new Forms.BookSale();
			frm.MdiParent = this;
            frm.Show();
        }

        private void izdavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.KeysRecord frm = new Forms.KeysRecord();
			frm.MdiParent = this;			
            frm.Show();
        }

        private void pregledIzdavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.KeysRecords frm = new Forms.KeysRecords();
			frm.MdiParent = this;
            frm.Show();
        }




	}
}
