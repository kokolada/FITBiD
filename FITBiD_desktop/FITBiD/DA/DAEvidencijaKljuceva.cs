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
		public static void GetEvidencijaByDNU(DSEvidencijaIzdavanjaKljuceva.EvidencijaKljucevasDataTable dtEvidencijaIzdavanja, DateTime datumPreuzimanja, DateTime datumVracanja, string nastavnik, string ucionica) {
			dtEvidencijaIzdavanja.Clear();
			SqlConnection cn = Connection.GetConnection();

			if (cn.State == System.Data.ConnectionState.Closed)
				cn.Open();
			try {
				SqlCommand cmd = new SqlCommand("usp_getEvidencijaByDNU", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				if (nastavnik != "")
					cmd.Parameters.Add("@Nastavnik", SqlDbType.NVarChar).Value = nastavnik;
				if (ucionica != "")
					cmd.Parameters.Add("@Ucionica", SqlDbType.NVarChar).Value = ucionica;
				if (datumPreuzimanja != null)
					cmd.Parameters.Add("@DatumPreuzimanja", SqlDbType.DateTime).Value = datumPreuzimanja;
				if (datumVracanja != null)
					cmd.Parameters.Add("@DatumVracanja", SqlDbType.DateTime).Value = datumVracanja;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dtEvidencijaIzdavanja);

				
			}
			finally {
				cn.Close();
			}
			
		}

	}
}
