﻿using FITBiD.DA;
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
    public partial class Rezervacije : Form
    {
        DSKnjige.RezervacijeKnjigaDataTable dtRezervacije = new DSKnjige.RezervacijeKnjigaDataTable();
        int id = new int();
        public Rezervacije()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Rezervacije_Load(object sender, EventArgs e)
        {
            dtRezervacije.Clear();

            DA.DAKnjige.GetRezervacijeByKSP(dtRezervacije, txtKnjiga.Text, txtStudent.Text, cbxPotvrdjena.Checked, true);

            dgRezervacije.AutoGenerateColumns = false;

            dgRezervacije.DataSource = dtRezervacije;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dtRezervacije.Clear();

            DA.DAKnjige.GetRezervacijeByKSP(dtRezervacije, txtKnjiga.Text, txtStudent.Text, cbxPotvrdjena.Checked, false);

            dgRezervacije.AutoGenerateColumns = false;

            dgRezervacije.DataSource = dtRezervacije;
        }

        private void dgRezervacije_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgRezervacije.SelectedRows[0].Cells[1].Value);
            Forms.StudentDetails frm = new StudentDetails(id);
            frm.Show();
        }
    }
}
