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
			if (txtIme.Text != "" && txtPrezime.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtEmail.Text !="")
			{
				DARadnici.InsertRadnik(txtIme.Text, txtPrezime.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text);
				/*dodati validaciju i obavijest o uspješnosti*/
				MessageBox.Show("Dodavanje radnika je uspješno izvršeno!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
				Forms.Workers frm = new Forms.Workers();
				frm.Show();
			}
			else
			{
				MessageBox.Show("Dodavanje radnika je neuspješno izvršeno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ClearForm();
			}

		}

		private void ClearForm()
		{
			txtIme.Text = ""; 
			txtPrezime.Text = ""; 
			txtEmail.Text = ""; 
			txtUsername.Text = ""; 
			txtPassword.Text = "";
		}


		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void AddWorker_Load(object sender, EventArgs e)
		{

		}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
