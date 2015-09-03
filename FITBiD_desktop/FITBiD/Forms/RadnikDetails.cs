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
    public partial class RadnikDetails : Form
    {
        DA.DSRadinici.RadniciDataTable dt = new DA.DSRadinici.RadniciDataTable();
        DA.DSLogin.RadnikDataTable dtRadnici = new DA.DSLogin.RadnikDataTable();
        int RadnikId;
        string RadnikIme;

        public RadnikDetails(string radnik, int id)
        {
            InitializeComponent();
            RadnikIme = radnik;
            RadnikId = id;
        }

        private void RadnikDetails_Load(object sender, EventArgs e)
        {
            DA.DARadnici.getRadnikById(dt, RadnikId);
            txtIme.Text = dt[0].Ime;
            txtPrezime.Text = dt[0].Prezime;
            txtKontakt.Text = dt[0].Username;
            txtEmail.Text = dt[0].Email;

            DA.DALoginEvidencija.GetLoginByRadnik(dtRadnici, RadnikIme);
            dataGridView1.AutoGenerateColumns = false;

            txtukupno.Text = dtRadnici.Count.ToString();

            dataGridView1.DataSource = dtRadnici;
        }
    }
}
