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
        int id = new int();

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
            bindGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindGrid();
        }
        
        private void bindGrid()
        {
            DAStudenti.getStudents(dtStudents, txtIme.Text, txtPrezime.Text, txtIndex.Text);
            dgStudents.AutoGenerateColumns = false;
            dgStudents.DataSource = dtStudents;
            txtBrojStudentata.Text = dtStudents.Count.ToString();
        }

        private void dgStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgStudents.SelectedRows[0].Cells[0].Value);
            Forms.StudentDetails frm = new StudentDetails(id);
            frm.Show();
        }
    }
}
