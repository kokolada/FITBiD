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
    public partial class MenadzmentDetails : Form
    {
        DA.DSMenadzeri.ManagementDataTable dt = new DA.DSMenadzeri.ManagementDataTable();
        DA.DSLogin.MenadzemntDataTable dtManagementGrid = new DA.DSLogin.MenadzemntDataTable();
        string Manager;
        int ManagerId;
        public MenadzmentDetails(String manager, int id)
        {
            InitializeComponent();
            Manager = manager;
            ManagerId = id;
        }

        private void RadnikDetails_Load(object sender, EventArgs e)
        {
            DA.DAMenadzeri.GetManagerById(dt, ManagerId);
            txtIme.Text = dt[0].Ime;
            txtPrezime.Text = dt[0].Prezime;
            txtKontakt.Text = dt[0].Username;
            txtEmail.Text = dt[0].Email;

            DA.DALoginEvidencija.GetLoginByMenadzment(dtManagementGrid, Manager);
            dataGridView1.AutoGenerateColumns = false;

            txtukupno.Text = dtManagementGrid.Count.ToString();

            dataGridView1.DataSource = dtManagementGrid;

        }
    }
}
