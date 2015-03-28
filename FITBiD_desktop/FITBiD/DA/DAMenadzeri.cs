using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITBiD.DA
{
	class DAMenadzeri
	{
		public static int ProvjeriLoginPodatke(string username, string password)
		{
			
			DSMenadzeri.MenadzmentsDataTable menadzer = new DSMenadzeri.MenadzmentsDataTable();
			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();
			int MenadzerID;
			try
			{
				SqlCommand cmd = new SqlCommand("usp_getMenadzerLogin", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@username", username);
				cmd.Parameters.Add("@password", password);
			
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(menadzer);
				MenadzerID = Convert.ToInt32(menadzer.IdColumn.Table.Rows[0]["Id"].ToString());
			}
			finally
			{
				cn.Close();
			}


			if (MenadzerID > 0)
				return MenadzerID;
			return 0;
		}
	}
}
