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

namespace FITBiD
{
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}

		private void loginSubmit_Click(object sender, EventArgs e)
		{

			Menu frm_menu = new Menu();
			
			DALoginEvidencija.LogiraniKorisnik = DA.DAMenadzeri.ProvjeriLoginPodatke(loginUsername.Text, loginPassword.Text);
			if (DALoginEvidencija.LogiraniKorisnik > 0)
			{
				frm_menu.Show();
				DALoginEvidencija.EvidencijaLogina(DateTime.Now, DALoginEvidencija.LogiraniKorisnik);
				this.Hide();
			}
			
		}

		private void Start_Load(object sender, EventArgs e) {

		}
	}
}
