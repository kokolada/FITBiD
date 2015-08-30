using System;
using System.Collections.Generic;
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

	}
}
