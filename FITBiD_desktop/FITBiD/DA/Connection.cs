using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITBiD.DA {
	class Connection {
		public static SqlConnection GetConnection() {
			SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
			connection.Open();
			return connection;
		}

	}
}
