using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITBiD.DA {
	class DALoginEvidencija {
		public static int LogiraniKorisnik { get; set; }

		public static void EvidencijaLogina(DateTime datumLogina, int MenadzmentId) {
			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try {
				SqlCommand cmd = new SqlCommand("usp_LoginEvidencija_Insert_Desktop", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add("@DatumLogina", SqlDbType.DateTime).Value = datumLogina;
				cmd.Parameters.Add("@MenadzmentID", SqlDbType.Int).Value = MenadzmentId;

				cmd.ExecuteNonQuery();
			}
			finally {
				cn.Close();
			}
		}

        public static void GetLoginByRadnik(DSLogin.RadnikDataTable dtRadnici, string Radnik)
        {
            dtRadnici.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_getLoginByRadnik", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Radnik != "")
                {
                    cmd.Parameters.Add("@radnik", SqlDbType.NVarChar).Value = Radnik;
                }
                

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtRadnici);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetLoginByStudent(DSLogin.StudentDataTable dtStudenti, string Student)
        {
            dtStudenti.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_getLoginByStudent", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Student != "")
                {
                    cmd.Parameters.Add("@student", SqlDbType.NVarChar).Value = Student;
                }
                

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtStudenti);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetLoginByMenadzment(DSLogin.MenadzemntDataTable dtManagement, string Management)
        {
            dtManagement.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_getLoginByMenadzemnt", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Management != "")
                {
                    cmd.Parameters.Add("@menadzemnt", SqlDbType.NVarChar).Value = Management;                  
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtManagement);
            }
            finally
            {
                cn.Close();
            }
        }


	}
}
