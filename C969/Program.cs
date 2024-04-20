using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
	public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//public static MySqlConnection connection;

			// connect to database -------------------------------------------
			DBConnection.startConnection();
		
			// open login form ------------------------------------------------
			Application.Run(new Login());

			// disconnect from database
			DBConnection.closeConnection();
		}
	}
}
