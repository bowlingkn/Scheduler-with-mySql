using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace C969
{
	class TrackLogin
	{
		public static void trackSuccess(string username, DateTime time) 
		{
			  StreamWriter fileWriter;
			 string fileName = "../../tracker.txt";
			 FileStream output = new FileStream(fileName, FileMode.Append, FileAccess.Write);

			try
			{
				fileWriter = new StreamWriter(output);

				fileWriter.WriteLine($"Successful login: {username} {time}");

				fileWriter.Close();
			}
			catch
			{
				MessageBox.Show("Login not tracked.");
			}
		}

		public static void trackFail(string username, DateTime time)
		{
			StreamWriter fileWriter;
			string fileName = "../../tracker.txt";
			FileStream output = new FileStream(fileName, FileMode.Append, FileAccess.Write);

			try
			{
				fileWriter = new StreamWriter(output);

				fileWriter.WriteLine($"Failed login: {username} {time}");

				fileWriter.Close();
			}
			catch 
			{
				MessageBox.Show("Failed login not tracked.");
			}
		}
	}
}
