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
    }
}
