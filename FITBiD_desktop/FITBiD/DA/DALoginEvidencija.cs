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
				SqlCommand cmd = new SqlCommand("ups_LoginEvidencija_Insert", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@DatumLogina", SqlDbType.DateTime);
				cmd.Parameters.Add("@MenadzmentID", SqlDbType.Int);

				//SqlParameter returnParameter = cmd.Parameters.Add("@Id", SqlDbType.Int);
				//returnParameter.Direction = ParameterDirection.Output;

				cmd.ExecuteNonQuery();
				//return Convert.ToInt32(returnParameter.Value);
			}
			finally {
				cn.Close();
			}
		}
	}
}
