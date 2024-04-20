using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
	class LoadData
	{
		public static BindingList<apptObject> apptList { get; set; }
		public static BindingList<custObject> custList { get; set; }
		public static BindingList<string> typeList { get; set; }
		public static BindingList<string> userList { get; set; }
		public static BindingList<int> custIdList { get; set; }

		delegate DateTime SubtractDays(DateTime a, int b);


		public static void loadAppt()
		{
			string sql = "SELECT userName, start, end, type, customerId, appointment.userId, appointmentId FROM user, appointment WHERE user.userId = appointment.userId ORDER BY start;";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			MySqlDataReader reader = cmd.ExecuteReader();
			apptList = new BindingList<apptObject>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					apptList.Add(new apptObject(reader.GetString(0), reader.GetDateTime(1).ToLocalTime(), reader.GetDateTime(2).ToLocalTime(), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6)));
				}
			}
			else
			{
				MessageBox.Show("No appointments found.");
			}

			reader.Close();

			// creates a list of all appointment types (used for reports)
			sql = "SELECT DISTINCT type FROM appointment";
			cmd = new MySqlCommand(sql, DBConnection.connection);
			reader = cmd.ExecuteReader();
			typeList = new BindingList<string>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					typeList.Add(reader.GetString(0));
				}
			}
			else 
			{
				MessageBox.Show("No types found.");
			}

			reader.Close();

			// creates a list of all usernames
			sql = "SELECT DISTINCT userName FROM user";
			cmd = new MySqlCommand(sql, DBConnection.connection);
			reader = cmd.ExecuteReader();
			userList = new BindingList<string>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					userList.Add(reader.GetString(0));
				}
			}
			else
			{
				MessageBox.Show("No types found.");
			}

			reader.Close();

			// creates a list of all customer IDs
			sql = "SELECT DISTINCT customerId FROM customer";
			cmd = new MySqlCommand(sql, DBConnection.connection);
			reader = cmd.ExecuteReader();
			custIdList = new BindingList<int>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					custIdList.Add(reader.GetInt32(0));
				}
			}
			else
			{
				MessageBox.Show("No types found.");
			}

			reader.Close();
		}

		public static void loadWeek(DateTime currentDate)		// load this week appointments
		{
			SubtractDays subtract = (a, b) =>  // lambda expression to give a datetime minus number of days
					{						   // lambda used because function needed multiple times but only in this part of program
						int currentDay = a.Day;
						int newDay = currentDay - b;
						return new DateTime(a.Year, a.Month, newDay);
					};

			string day = currentDate.DayOfWeek.ToString();
			DateTime startDate, endDate;
			startDate = new DateTime(1990, 1, 31);
			endDate = startDate;
			
			switch (day)
			{
				case "Monday":
					startDate = currentDate;
					endDate = currentDate.AddDays(4);
					break;
				case "Tuesday":
					startDate = subtract(currentDate, 1);
					endDate = currentDate.AddDays(3);
					break;
				case "Wednesday":
					startDate = subtract(currentDate, 2);
					endDate = currentDate.AddDays(2);
					break;
				case "Thursday":
					startDate = subtract(currentDate, 3);
					endDate = currentDate.AddDays(1);
					break;
				case "Friday":
					startDate = subtract(currentDate, 4);
					endDate = currentDate;
					break;
				case "Saturday":
					startDate = subtract(currentDate, 5);
					endDate = subtract(currentDate, 1);
					break;
				case "Sunday":
					startDate = currentDate.AddDays(1);
					endDate = currentDate.AddDays(5);
					break;
				default:
					MessageBox.Show("switch statement no work.");
					break;
			}

			string sql = "SELECT userName, start, end, type, customerId, appointment.userId, appointmentId FROM user, appointment WHERE user.userId = appointment.userId AND start >= @start AND start <= @end";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("start", startDate);
			cmd.Parameters.AddWithValue("end", endDate);
			MySqlDataReader reader = cmd.ExecuteReader();
			apptList = new BindingList<apptObject>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					apptList.Add(new apptObject(reader.GetString(0), reader.GetDateTime(1).ToLocalTime(), reader.GetDateTime(2).ToLocalTime(), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6)));
				}
			}
			else
			{
				reader.Close();
				MessageBox.Show("No appointments found this week.");
			}

			reader.Close();
		}

		public static void loadMonth(DateTime currentDate)		// load this month appointments
		{
			int month = currentDate.Month;
			int year = currentDate.Year;
			DateTime startMonth = new DateTime(year, month, 1);
			DateTime endMonth = new DateTime(year, month + 1, 1);
			string sql = "SELECT userName, start, end, type, customerId, appointment.userId, appointmentId FROM user, appointment WHERE user.userId = appointment.userId AND start >= @startMonth AND start < @endMonth";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("startMonth", startMonth);
			cmd.Parameters.AddWithValue("endMonth", endMonth);
			MySqlDataReader reader = cmd.ExecuteReader();
			apptList = new BindingList<apptObject>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					apptList.Add(new apptObject(reader.GetString(0) ,reader.GetDateTime(1).ToLocalTime(), reader.GetDateTime(2).ToLocalTime(), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6))); ;
				}
			}
			else
			{
				reader.Close();
				MessageBox.Show("No appointments found this month.");
			}

			reader.Close();
		}

		public static void loadCust()
		{
			string sql = "SELECT customer.customerId, customer.customerName, address.phone, address.address, city.city, country.country FROM customer, address, city, country WHERE customer.addressId=address.addressId AND address.cityId=city.cityId AND city.countryId=country.countryId";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			MySqlDataReader reader = cmd.ExecuteReader();
			custList = new BindingList<custObject>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					custList.Add(new custObject(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
				}
			}
			else
			{
				MessageBox.Show("No rows found.");
			}

			reader.Close();
		}
	}
}
