using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITBiD.Forms
{
    public partial class KeysRecords : Form
    {
        DA.DSEvidencijaIzdavanjaKljuceva.EvidencijaKljucevasDataTable kljucevi = new DA.DSEvidencijaIzdavanjaKljuceva.EvidencijaKljucevasDataTable();
        public KeysRecords()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void KeysRecords_Load(object sender, EventArgs e)
        {
            DA.DAKljucevi.GetEvidencijeKljuceva(kljucevi);
            dataGridView1.DataSource = kljucevi;
        }

		private void traziBtn_Click(object sender, EventArgs e) {
			DA.DAEvidencijaKljuceva.GetEvidencijaByDNU(kljucevi,datumPreuzimanjaPicker.Value.Date,datumVracanjaPicker.Value.Date,nastavnikTxb.Text,ucionicaTxb.Text);
			dataGridView1.DataSource = kljucevi;
		}
    }
}
