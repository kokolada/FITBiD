using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			if (DA.DAMenadzeri.ProvjeriLoginPodatke(loginUsername.Text, loginPassword.Text))
			{
				frm_menu.Show();
				//DA.DALoginEvidencija.LogiraniKorisnik = DA.DALoginEvidencija.EvidencijaLogina(DateTime.Now,menadzmentId);
				this.Hide();
			}
			
		}

		private void Start_Load(object sender, EventArgs e) {

		}
	}
}
