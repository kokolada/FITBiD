using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITBiD.DA
{
    class DAKljucevi
    {
        public static void GetAllKljucevi(DSEvidencijaKljucevaV2.KljucsDataTable dtKljucevi)
        {
            dtKljucevi.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_GetAllKljucevi", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKljucevi);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetEvidencijeKljuceva(DSEvidencijaIzdavanjaKljuceva.EvidencijaKljucevasDataTable dtEvidencijeKljuceva)
        {
            dtEvidencijeKljuceva.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_getEvidencijeKljuceva", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtEvidencijeKljuceva);
            }
            finally
            {
                cn.Close();
            }
        }


    }
}
