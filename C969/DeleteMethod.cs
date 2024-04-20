using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
	class DeleteMethod
	{
		public static int deleteCustomer(int custId)
		{
			var sql = "SELECT addressId FROM customer WHERE customerId = @custId";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("custId", custId);
			cmd.Prepare();
			int addId = Convert.ToInt32(cmd.ExecuteScalar());

			sql = "DELETE FROM customer WHERE customerId = @custId";
			cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("custId", custId);
			cmd.Prepare();
			cmd.ExecuteNonQuery();
		
			return addId;
		}

		public static int deleteAddress(int addId)
		{
			var sql = "SELECT cityId FROM address WHERE addressId = @addId";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("addId", addId);
			cmd.Prepare();
			int cityId = Convert.ToInt32(cmd.ExecuteScalar());

			sql = "DELETE FROM address WHERE addressId = @addId";
			cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("addId", addId);
			cmd.Prepare();
			cmd.ExecuteNonQuery();

			return cityId;
		}

		public static int deleteCity(int cityId)
		{
			var sql = "SELECT countryId FROM city WHERE cityId = @cityId";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("cityId", cityId);
			cmd.Prepare();
			int countryId = Convert.ToInt32(cmd.ExecuteScalar());

			sql = "DELETE FROM city WHERE cityId = @cityId";
			cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("cityId", cityId);
			cmd.Prepare();
			cmd.ExecuteNonQuery();

			return countryId;
		}

		public static void deleteCountry(int countryId)
		{
			var sql = "DELETE FROM country WHERE countryId = @countryId";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("countryId", countryId);
			cmd.Prepare();
			cmd.ExecuteNonQuery();
		}

	}
}
