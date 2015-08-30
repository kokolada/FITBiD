using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITBiD.DA {
	class DAEvidencijaIznajmljivanja {
		public static void GetEvidencijeIznajmljivanja(DA.DSEvidencijaIznajmljivanjaKnjiga.EvidencijaKnjigaZaIznajmljivanjesDataTable dtIznajmljeneKnjige) {
			dtIznajmljeneKnjige.Clear();

			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try {
				SqlCommand cmd = new SqlCommand("usp_GetEvidencijeIznajmljivanjaKnjiga", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dtIznajmljeneKnjige);
			}
			finally {
				cn.Close();
			}

		}
		public static void GetEvidencijaIznajmljivanjaByDKRS(DA.DSEvidencijaIznajmljivanjaKnjiga.EvidencijaKnjigaZaIznajmljivanjesDataTable dtIznajmljeneKnjige,DateTime datumIzdavanja,DateTime datumVracanja,string knjiga,string radnik, string student){
			dtIznajmljeneKnjige.Clear();
			SqlConnection cn = Connection.GetConnection();

			if (cn.State == System.Data.ConnectionState.Closed)
				cn.Open();
			try {
				SqlCommand cmd = new SqlCommand("usp_GetEvidencijaIznajmljivanjaByDKRS", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				if (knjiga != "")
					cmd.Parameters.Add("@Knjiga", SqlDbType.NVarChar).Value = knjiga;
				if (radnik != "")
					cmd.Parameters.Add("@Radnik", SqlDbType.NVarChar).Value = radnik;
				if (student != "")
					cmd.Parameters.Add("@Student", SqlDbType.NVarChar).Value = student;
				if (datumIzdavanja != null)
					cmd.Parameters.Add("@DatumIzdavanja", SqlDbType.DateTime).Value = datumIzdavanja;
				if (datumVracanja != null)
					cmd.Parameters.Add("@DatumVracanja", SqlDbType.DateTime).Value = datumVracanja;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dtIznajmljeneKnjige);
			}
			finally {
				cn.Close();
			}

		}

	}
}
