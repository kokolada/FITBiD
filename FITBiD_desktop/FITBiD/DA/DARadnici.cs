using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FITBiD.Forms;
using FITBiD.DA;

namespace FITBiD.DA {
	class DARadnici {
		public static void InsertRadnik(string ime, string prezime, string email, string username, string password) {	
			SqlConnection cn = Connection.GetConnection();

			if(cn.State == System.Data.ConnectionState.Closed)
				cn.Open();
			try {
				SqlCommand cmd = new SqlCommand("usp_Radnik_Add", cn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				cmd.Parameters.Add("@Ime", SqlDbType.NVarChar).Value = ime;
				cmd.Parameters.Add("@Prezime", SqlDbType.NVarChar).Value = prezime;
				cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
				cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
				cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

				cmd.ExecuteNonQuery();
			}
			finally {
				cn.Close();
			}		
		}

		public static void getRadnici(DSRadinici.RadniksDataTable dtRadnici) {
				dtRadnici.Clear();
				SqlConnection cn = Connection.GetConnection();
				if(cn.State == ConnectionState.Closed)
					cn.Open();

				try {
					SqlCommand cmd = new SqlCommand("usp_Select_Radniks",cn);
					cmd.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(dtRadnici);
				}
				finally {
					cn.Close();
				}
		}

		public static void getRadniciByNLU(DSRadinici.RadniksDataTable dtRadnici, string Imetxt, string Prezimetxt, string Usernametxt) {
				dtRadnici.Clear();
				SqlConnection cn = Connection.GetConnection();
				if (cn.State == ConnectionState.Closed)
					cn.Open();

				try {
					SqlCommand cmd = new SqlCommand("usp_GetRadnikByNLU", cn);
					cmd.CommandType = CommandType.StoredProcedure;

					if(Imetxt != "")
						cmd.Parameters.Add("@Ime", SqlDbType.NVarChar).Value = Imetxt;
					if(Prezimetxt != "")
						cmd.Parameters.Add("@Prezime", SqlDbType.NVarChar).Value = Prezimetxt;
					if (Usernametxt != "")
						cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Usernametxt;

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);		
					adapter.Fill(dtRadnici);
				}
				finally {
					cn.Close();
				}
		}


		public static void getRadnici(DSEvidencijaKljucevaV2.RadniksDataTable radniksDataTable)
		{
			radniksDataTable.Clear();
			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try {
				SqlCommand cmd = new SqlCommand("usp_Select_Radniks", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(radniksDataTable);
			}
			finally {
				cn.Close();
			}
		}

        public static void getRadnikById(DSRadinici.RadniciDataTable dtRadnici, int id)
        {
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_getRadnikById", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
               
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtRadnici);
            }
            finally
            {
                cn.Close();
            }
        }
	}
}
