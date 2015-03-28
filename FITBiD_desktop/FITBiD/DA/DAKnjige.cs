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
		public static void AddKnjiga(string autor, string barcode, int cijena, string godina, string naziv, string oznaka, bool zaprodaju)
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
	}
}
