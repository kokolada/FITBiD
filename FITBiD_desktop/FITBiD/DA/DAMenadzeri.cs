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
			try
			{
				SqlCommand cmd = new SqlCommand("usp_getMenadzerLogin", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@username", username);
				cmd.Parameters.Add("@password", password);
			
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(menadzer);
				
			}
			finally
			{
				cn.Close();
			}


			if (menadzer.Count > 0) { 
				int MenadzerID = Convert.ToInt32(menadzer.IdColumn.Table.Rows[0]["Id"].ToString()); 
				return MenadzerID;
			}
			return 0;
		}

        public static void GetManagerById(DA.DSMenadzeri.ManagementDataTable dt, int id)
        {
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_getManagementById", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                cn.Close();
            }
        }
	}
}
