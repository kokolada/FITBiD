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
			frm_menu.Show();
			/*if (loginUsername.Text != "" && loginPassword.Text != "") {
				//pusti korisnika na glavnu formu

			}*/
		}
	}
}
