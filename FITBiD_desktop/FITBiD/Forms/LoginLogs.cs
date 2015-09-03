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
    public partial class LoginLogs : Form
    {
        DA.DSLogin.RadnikDataTable dtRadnici = new DA.DSLogin.RadnikDataTable();
        DA.DSLogin.StudentDataTable dtStudenti = new DA.DSLogin.StudentDataTable();
        DA.DSLogin.MenadzemntDataTable dtManagement = new DA.DSLogin.MenadzemntDataTable();
        int id = new int();
        public LoginLogs()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DA.DALoginEvidencija.GetLoginByRadnik(dtRadnici, txtRadnik.Text);
            DA.DALoginEvidencija.GetLoginByStudent(dtStudenti, txtStudent.Text);
            DA.DALoginEvidencija.GetLoginByMenadzment(dtManagement, txtManagement.Text);

            dgRadnici.AutoGenerateColumns = false;
            dgStudenti.AutoGenerateColumns = false;
            dgManagement.AutoGenerateColumns = false;

            dgRadnici.DataSource = dtRadnici;
            dgStudenti.DataSource = dtStudenti;
            dgManagement.DataSource = dtManagement;
        }

        private void txtManagement_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DA.DALoginEvidencija.GetLoginByRadnik(dtRadnici, txtRadnik.Text);
            dgRadnici.DataSource = dtRadnici;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DA.DALoginEvidencija.GetLoginByStudent(dtStudenti, txtStudent.Text);
            dgStudenti.DataSource = dtStudenti;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DA.DALoginEvidencija.GetLoginByMenadzment(dtManagement, txtManagement.Text);
            dgManagement.DataSource = dtManagement;

        }

        private void dgStudenti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgStudenti.SelectedRows[0].Cells[1].Value);
            Forms.StudentDetails frm = new StudentDetails(id);
            frm.Show();
        }

        private void dgManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgManagement_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgManagement.SelectedRows[0].Cells[1].Value);
            Forms.MenadzmentDetails frm = new MenadzmentDetails(dgManagement.SelectedRows[0].Cells[3].Value.ToString(), id);
            frm.Show();
        }

        private void dgRadnici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgRadnici.SelectedRows[0].Cells[1].Value);
            Forms.RadnikDetails frm = new RadnikDetails(dgRadnici.SelectedRows[0].Cells[3].Value.ToString(), id);
            frm.Show();
        }


    }
}
