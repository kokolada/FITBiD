using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITBiD.DA {
	class DAEvidencijaPrijava {
		public static void GetEvidencijaPrijava(DSEvidencijaPrijava.EvidencijaPrijavasDataTable dtPrijave) {
			SqlConnection cn = Connection.GetConnection();

			if (cn.State == System.Data.ConnectionState.Closed)
				cn.Open();
			try {
				SqlCommand cmd = new SqlCommand("usp_GetEvidencijePrijava", cn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dtPrijave);
			}
			finally {
				cn.Close();
			}
		}
		public static void GetEvidencijaBySRK(DSEvidencijaPrijava.EvidencijaPrijavasDataTable dtPrijave,string student,string radnik,string kolicina) {
			dtPrijave.Clear();
			SqlConnection cn = Connection.GetConnection();

			if (cn.State == System.Data.ConnectionState.Closed)
				cn.Open();
			try {
				SqlCommand cmd = new SqlCommand("usp_GetEvidencijaBySRK", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				if (student != "")
					cmd.Parameters.Add("@Student", SqlDbType.NVarChar).Value = student;
				if (radnik != "")
					cmd.Parameters.Add("@Radnik", SqlDbType.NVarChar).Value = radnik;
				if (kolicina != "")
					cmd.Parameters.Add("@Kolicina", SqlDbType.Int).Value = Convert.ToInt32(kolicina);

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dtPrijave);

			}
			finally {
				cn.Close();
			}
		}

	}
}
