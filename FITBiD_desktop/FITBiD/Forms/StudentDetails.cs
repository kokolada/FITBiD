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

namespace FITBiD.Forms
{
    public partial class StudentDetails : Form
    {
        DSStudents.Student_FullDataTable dtStudent = new DSStudents.Student_FullDataTable();
        DSStudents.Student_IznajmljivanjeDataTable dtIznajmljivanje = new DSStudents.Student_IznajmljivanjeDataTable();
        DSStudents.Student_RezervacijeDataTable dtRezervacije = new DSStudents.Student_RezervacijeDataTable();
        int studentId;
        public StudentDetails(int id)
        {
            InitializeComponent();
            studentId = new int();
            studentId = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            DA.DAStudenti.getStudentById(dtStudent, studentId);
            txtIme.Text = dtStudent[0].Ime;
            txtPrezime.Text = dtStudent[0].Prezime;
            txtIndex.Text = dtStudent[0].BrojIndeksa;
            txtTelefon.Text = dtStudent[0].Kontakt;
            txtEmail.Text = dtStudent[0].Email;

            DA.DAStudenti.getStudentIznajmljivanja(dtIznajmljivanje, studentId);
            DA.DAStudenti.getStudentReservations(dtRezervacije, studentId);

            txtIznajmljene.Text = dtIznajmljivanje.Count.ToString();
            txtRezervisane.Text = dtRezervacije.Count.ToString();

            dgRezervisane.AutoGenerateColumns = false;
            dgIznajmljene.AutoGenerateColumns = false;

            dgIznajmljene.DataSource = dtIznajmljivanje;
            dgRezervisane.DataSource = dtRezervacije;

        }
    }
}
