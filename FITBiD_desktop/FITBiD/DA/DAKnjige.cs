using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITBiD.DA
{
	class DAKnjige
	{
		public static void AddKnjiga(string autor, string barcode, int cijena, int godina, string naziv, string oznaka, bool zaprodaju)
		{
			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("usp_AddKnjiga", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@naziv", naziv);
				cmd.Parameters.Add("@autor", autor);
				cmd.Parameters.Add("@godina", godina);
				cmd.Parameters.Add("@barcode", barcode);
				cmd.Parameters.Add("@oznaka", oznaka);
				cmd.Parameters.Add("@zaprodaju", zaprodaju);
				cmd.Parameters.Add("@cijena", cijena);

				cmd.ExecuteNonQuery();
			}
			finally
			{
				cn.Close();
			}
		}

		public static void SaleKnjiga(int knjigaId)
		{
			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("usp_insertPodajaKnjige", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@id", knjigaId);
		
				cmd.ExecuteNonQuery();
			}
			finally
			{
				cn.Close();
			}
		}

		public static void KnjigaSearch(DSKnjige.KnjigasDataTable knjige, string naziv, string autor)
		{
			knjige.Clear();
			// = null;
			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("usp_KnjigaPretraga", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				if(naziv != "")
				cmd.Parameters.Add("@Naziv",naziv);

				if(autor != "")
				cmd.Parameters.Add("@Autor", autor);

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				adapter.Fill(knjige);
			}
			finally
			{
				cn.Close();
			}
		}

		public static DSEvidencijaProdaje.EvidencijaKnjigaZaProdajusDataTable getProdateKnjige(DSEvidencijaProdaje.EvidencijaKnjigaZaProdajusDataTable dt)
		{
			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("usp_ListaProdatihKnjiga", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				adapter.Fill(dt);

				return dt;
			}
			finally
			{
				cn.Close();
			}
		}

        public static DSKnjige.KnjigasDataTable getLastAddedBook(DSKnjige.KnjigasDataTable dt)
		{
			

			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("getLastAddedBook", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				adapter.Fill(dt);

				return dt;
			}
			finally
			{
				cn.Close();
			}
		}

		public static DSEvidencijaProdaje.EvidencijaKnjigaZaProdajusDataTable getProdateKnjigeByNaziv(DSEvidencijaProdaje.EvidencijaKnjigaZaProdajusDataTable dt, string knjiga )
		{
			dt.Clear();
			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("usp_prodaneKnjigeByNaziv", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				if (knjiga.Length == 0)
				{
					cmd.Parameters.Add("nazivKnjige", null);                    
				}
				else
					cmd.Parameters.Add("nazivKnjige", knjiga);

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				adapter.Fill(dt);

				return dt;
			}
			finally
			{
				cn.Close();
			}
		}
		public static void GetProdateKnjigeByKRD(DSEvidencijaProdaje.EvidencijaKnjigaZaProdajusDataTable dtProdane, DateTime datum, string knjiga, string radnik) {
			dtProdane.Clear();
			SqlConnection cn = Connection.GetConnection();

			if (cn.State == System.Data.ConnectionState.Closed)
				cn.Open();
			try {
				SqlCommand cmd = new SqlCommand("usp_GetProdateKnjigeByKRD", cn);
				cmd.CommandType = CommandType.StoredProcedure;

				if (knjiga != "")
					cmd.Parameters.Add("@Knjiga", SqlDbType.NVarChar).Value = knjiga;
				if (radnik != "")
					cmd.Parameters.Add("@Radnik", SqlDbType.NVarChar).Value = radnik;
				if (datum != null)
					cmd.Parameters.Add("@Datum", SqlDbType.DateTime).Value = datum;
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dtProdane);
			}
			finally {
				cn.Close();
			}
		}


	}
}
