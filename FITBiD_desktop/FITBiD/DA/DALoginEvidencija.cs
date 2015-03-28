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
	}
}
