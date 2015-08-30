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

namespace FITBiD.Forms
{
    public partial class Students : Form
    {
        DSStudents.Student_PreviewDataTable dtStudents = new DSStudents.Student_PreviewDataTable();
        public Students()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Students_Load(object sender, EventArgs e)
        {
            DAStudenti.getStudents(dtStudents, txtIme.Text, txtPrezime.Text, txtIndex.Text);
            dgStudents.AutoGenerateColumns = false;
            dgStudents.DataSource = dtStudents;
            txtBrojStudentata.Text = dtStudents.Count.ToString();
        }
    }
}
