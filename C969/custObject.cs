using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969
{
	public class custObject
	{
		public int custId { get; set; }
		public string name { get; set; }
		public string phone { get; set; }
		public string address { get; set; }
		public string city { get; set; }
		public string country { get; set; }

		public custObject(int a, string b, string c, string d, string e, string f)
		{
			custId = a;
			name = b;
			phone = c;
			address = d;
			city = e;
			country = f;
		}
	}
}
