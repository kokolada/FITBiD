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
			frm.Show();
		}

		private void workersToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

		private void addWorkerToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.AddWorker frm = new Forms.AddWorker();
			frm.Show();
		}

		private void listOfWorkersToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Workers frm = new Forms.Workers();
			frm.Show();
		}

		private void KeysRecordToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("izdavanjeKljuceva");
			frm.Show();
		}

		private void booksRecordToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("izdavanjeKnjiga");
			frm.Show();
		}

		private void mostActiveStudentsToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najaktivnijiStudenti");
			frm.Show();
		}

		private void bestWorkersToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najboljiRadnici");
			frm.Show();
		}

		private void materialUseToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("potrosnjaMaterijala");
			frm.Show();
		}

		private void booksSalesToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("prodajaKnjiga");
			frm.Show();
		}

		private void mostActiveStudentToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najaktivnijiStudent");
			frm.Show();
		}

		private void mostActiveStudentOnSystemToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najaktivnijiStudentPoLoginu");
			frm.Show();
		}

		private void mostPopulatedCategoryToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.Reports frm = new Forms.Reports("najzastupljenijeKategorije");
			frm.Show();
		}


		private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Forms.AddBook frm = new Forms.AddBook();
			frm.Show();
		}

		private void recordToolStripMenuItem_Click(object sender, EventArgs e) {
			Forms.KeysRecord frm = new Forms.KeysRecord();
			frm.Show();
		}

		private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Forms.BookSearch frm = new Forms.BookSearch();
			frm.Show();
		}


	}
}
