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
		public static bool ProvjeriLoginPodatke(string username, string password)
		{
			DSMenadzeri.MenadzmentsDataTable menadzer = new DSMenadzeri.MenadzmentsDataTable();
			SqlConnection cn = Connection.GetConnection();
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("usp_getMenadzerLogin", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("username", username);
				cmd.Parameters.Add("password", password);

				//var returnParameter = cmd.Parameters.Add("@Result", SqlDbType.Int);
				//returnParameter.Direction = ParameterDirection.ReturnValue;
				
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(menadzer);

				//if (Convert.ToInt32(returnParameter.Value) > 0)
				//	return Convert.ToInt32(returnParameter.Value);
				//return 0;
			}
			finally
			{
				cn.Close();
			}


			if (menadzer.Count > 0)
				return true;
			return false;
		}
	}
}
