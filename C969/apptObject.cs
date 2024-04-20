using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969
{
	public class apptObject
	{
		public string username { get; set; }
		public DateTime start { get; set; }
		public DateTime end { get; set; }
		public string type { get; set; }
		public int customerId { get; set; }
		public int userId { get; set; }
		public int apptId { get; set; }
		
	
		// constructor
		public apptObject(string z, DateTime a, DateTime b, string c, int d, int e, int f)
		{
			username = z;
			start = a;
			end = b;
			type = c;
			customerId = d;
			userId = e;
			apptId = f;
		}

		public apptObject(string a, DateTime b, string c)
		{
			username = a;
			start = b;
			type = c;
		}

		public apptObject(int a, DateTime b, string c)
		{
			customerId = a;
			start = b;
			type = c;
		}

	}
}
