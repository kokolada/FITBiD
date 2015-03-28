using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FITBiD.DA;

namespace FITBiD.DA {
	class DAEvidencijaKljuceva {
		public static void EvidentirajKljuc(DateTime DatumPreuzimanja, DateTime DatumVracanja, int KljucID, 
												int NastavnoOsobljeID) {
			SqlConnection cn = Connection.GetConnection();

			if (cn.State == System.Data.ConnectionState.Closed)
				cn.Open();
			try {
				SqlCommand cmd = new SqlCommand("usp_EvidencijaKljuceva_Insert", cn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				cmd.Parameters.Add("@NastavnoOsobljeID", SqlDbType.Int).Value = NastavnoOsobljeID;
				cmd.Parameters.Add("@KljucID", SqlDbType.Int).Value = KljucID;
				cmd.Parameters.Add("@RadnikID", SqlDbType.Int).Value = DALoginEvidencija.LogiraniKorisnik;
				cmd.Parameters.Add("@DatumPreuzimanja", SqlDbType.DateTime).Value = DatumPreuzimanja;
				cmd.Parameters.Add("@DatumVracanja", SqlDbType.DateTime).Value = DatumVracanja;

				cmd.ExecuteNonQuery();
			}
			finally {
				cn.Close();
			}
		}

	}
}
