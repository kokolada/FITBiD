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
        DA.DSEvidencijaKljuceva.KljucsDataTable kljucevi = new DA.DSEvidencijaKljuceva.KljucsDataTable();
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
    }
}
