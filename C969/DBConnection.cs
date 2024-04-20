using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
	class DBConnection
	{
		public static MySqlConnection connection { get; set; }

		public static void startConnection()
		{
			try
			{
				string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
				connection = new MySqlConnection(constr);
				
				connection.Open();
			}
			catch
			{
				MessageBox.Show("not connected");
			}
		}

		public static void closeConnection()
		{
			try
			{
				if (connection != null)
				{
					connection.Close();
				}
				connection = null;
			}
			catch
			{
				MessageBox.Show("connection not closed");
			}
		}
	}
}
