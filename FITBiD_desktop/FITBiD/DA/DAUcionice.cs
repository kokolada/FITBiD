using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITBiD.DA {
	class DAUcionice {
			public static void GetAllUcionice(DSEvidencijaKljuceva.UcionicasDataTable dtUcionice) {
			dtUcionice.Clear();

			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try {
				SqlCommand cmd = new SqlCommand("usp_GetAllUcionice", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dtUcionice);
			}
			finally {
				cn.Close();
			}
		}
	}
}
