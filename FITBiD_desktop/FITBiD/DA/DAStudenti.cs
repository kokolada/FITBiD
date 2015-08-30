using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITBiD.DA
{
    class DAStudenti
    {
        public static void getStudents(DSStudents.Student_PreviewDataTable dtStudents, string ime, string prezime, string index)
        {
            dtStudents.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_getStudentsByImePrezimeIndex", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (ime != "")
                    cmd.Parameters.Add("@ime", SqlDbType.NVarChar).Value = ime;
                if (prezime != "")
                    cmd.Parameters.Add("@prezime", SqlDbType.NVarChar).Value = prezime;
                if (index != "")
                    cmd.Parameters.Add("@index", SqlDbType.NVarChar).Value = index;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtStudents);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void getStudentById(DSStudents.Student_FullDataTable dtStudent, int id)
        {
            dtStudent.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_getStudentById", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtStudent);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void getStudentReservations(DSStudents.Student_RezervacijeDataTable dtReservations, int id)
        {
            dtReservations.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_getRezervacijaByStudent", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@studentId", SqlDbType.Int).Value = id;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtReservations);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void getStudentIznajmljivanja(DSStudents.Student_IznajmljivanjeDataTable dtIznajmljivanja, int id)
        {
            dtIznajmljivanja.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_getInajmljivanjeByStudent", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@studentId", SqlDbType.Int).Value = id;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtIznajmljivanja);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
