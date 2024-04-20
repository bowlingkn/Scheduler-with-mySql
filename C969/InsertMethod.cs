using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
	public class InsertMethod
	{
		private static DateTime createDate = DateTime.UtcNow;
		private static string createdBy = "test";
		private static string lastUpdateBy = "test";
		public static void addCust(string name, int addId)
		{
			int active = 1;

			var sql = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy) VALUES (@name,@id,@active,@create,@createBy,@lastUpdate)";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("name", name);
			cmd.Parameters.AddWithValue("id", addId);
			cmd.Parameters.AddWithValue("active", active);
			cmd.Parameters.AddWithValue("create", createDate);
			cmd.Parameters.AddWithValue("createBy", createdBy);
			cmd.Parameters.AddWithValue("lastUpdate", lastUpdateBy);
			cmd.Prepare();
			cmd.ExecuteNonQuery();

		}

		public static int addAddress(string address, string phone, int cityId)
		{
			string add2 = ""; // default value
			string postal = "11111"; // default vallue


			var sql = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy) VALUES (@add,@add2,@cityId,@post,@phone,@create,@createBy,@lastUpdate)";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("add", address);
			cmd.Parameters.AddWithValue("add2", add2);
			cmd.Parameters.AddWithValue("cityId", cityId);
			cmd.Parameters.AddWithValue("post", postal);
			cmd.Parameters.AddWithValue("phone", phone);
			cmd.Parameters.AddWithValue("create", createDate);
			cmd.Parameters.AddWithValue("createBy", createdBy);
			cmd.Parameters.AddWithValue("lastUpdate", lastUpdateBy);
			cmd.Prepare();
			cmd.ExecuteNonQuery();

			sql = "SELECT addressId FROM address WHERE address=@address";
			cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("address", address);
			cmd.Prepare();
			int addressId = Convert.ToInt32(cmd.ExecuteScalar());
			return addressId; 
		}

		public static int addCity(string city, int countryId)
		{
			var sql = "INSERT INTO city(city, countryId, createDate, createdBy, lastUpdateBy) VALUES (@city,@countryId,@create,@createBy,@lastUpdate)";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("city", city);
			cmd.Parameters.AddWithValue("countryId", countryId);
			cmd.Parameters.AddWithValue("create", createDate);
			cmd.Parameters.AddWithValue("createBy", createdBy);
			cmd.Parameters.AddWithValue("lastUpdate", lastUpdateBy);
			cmd.Prepare();
			cmd.ExecuteNonQuery();

			sql = "SELECT cityId FROM city WHERE city=@city";
			cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("city", city);
			cmd.Prepare();
			int cityId = Convert.ToInt32(cmd.ExecuteScalar());
			return cityId;
		}

		public static int addCountry(string country)
		{
			var sql = "INSERT INTO country(country, createDate, createdBy, lastUpdateBy) VALUES (@country,@create,@createBy,@lastUpdate)";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("country", country);
			cmd.Parameters.AddWithValue("create", createDate);
			cmd.Parameters.AddWithValue("createBy", createdBy);
			cmd.Parameters.AddWithValue("lastUpdate", lastUpdateBy);
			cmd.Prepare();
			cmd.ExecuteNonQuery();

			sql = "SELECT countryId FROM country WHERE country=@country";
			cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("country", country);
			cmd.Prepare();
			int countryId = Convert.ToInt32(cmd.ExecuteScalar());
			return countryId;
		}


	}
}
