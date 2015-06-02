using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FITBiD.DA;
using System.Data.SqlClient;
using System.Data;

namespace FITBiD.DA {
	class DANastavnoOsoblje {
		public static void GetAllOsoblje(DSEvidencijaKljucevaV2.NastavnoOsobljesDataTable dtNastavnoOsoblje)
		{
			dtNastavnoOsoblje.Clear();

			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try {
				SqlCommand cmd = new SqlCommand("usp_GetAllNastavnoOsoblje", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dtNastavnoOsoblje);
			}
			finally {
				cn.Close();
			}
		}
	}
}
