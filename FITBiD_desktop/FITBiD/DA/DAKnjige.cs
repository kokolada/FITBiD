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

        public static void GetRezervacijeByKSP(DSKnjige.RezervacijeKnjigaDataTable dtRezervacije, string knjiga, string student, bool potvrdjena, bool firstCall)
        {
            dtRezervacije.Clear();
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_getRezervacijeByKSP", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (knjiga != "")
                    cmd.Parameters.Add("@knjiga", SqlDbType.NVarChar).Value = knjiga;
                if (student != "")
                    cmd.Parameters.Add("@student", SqlDbType.NVarChar).Value = student;
                if (!firstCall)
                    cmd.Parameters.Add("@potvrdjena", SqlDbType.Bit).Value = potvrdjena;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dtRezervacije);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void KnjigeSearch(DSKnjige.KnjigaPretragaDataTable dtKnjige, string Naziv, string Autor, string Barcode, bool ZaProdaju, int Min, int Max, bool firstCall)
        {
            dtKnjige.Clear();
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_getKnjigaByNGABZC", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Naziv != "")
                    cmd.Parameters.Add("@naziv", SqlDbType.NVarChar).Value = Naziv;
                if (Autor != "")
                    cmd.Parameters.Add("@autor", SqlDbType.NVarChar).Value = Autor;
                if (Barcode != "")
                    cmd.Parameters.Add("@barcode", SqlDbType.NVarChar).Value = Barcode;
                if (!firstCall)
                    cmd.Parameters.Add("@zaprodaju", SqlDbType.Bit).Value = ZaProdaju;
                if (Min >= 0 && Max >= 0)
                {
                    cmd.Parameters.Add("@cijenamin", SqlDbType.Int).Value = Min;
                    cmd.Parameters.Add("@cijenamax", SqlDbType.Int).Value = Max;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dtKnjige);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetIznajmljivanjeKnjigeById(DSKnjige.IznajmljivanjeDataTable dtKnjige, int id)
        {
            dtKnjige.Clear();
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_getInajmljivanjeByKnjiga", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@knjigaId", SqlDbType.Int).Value = id;                

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dtKnjige);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetRezervacijeKnjigeById(DSKnjige.RezervacijeDataTable dtKnjige, int id)
        {
            dtKnjige.Clear();
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_getRezervacijaByKnjiga", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@knjigaId", SqlDbType.Int).Value = id;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dtKnjige);
            }
            finally
            {
                cn.Close();
            }
        }

	}
}
