using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
	public partial class customer : Form
	{
		public customer()
		{
			InitializeComponent();

			if (Scheduler.ModifyCust) // modifying customer
			{
				tbName.Text = LoadData.custList[Scheduler.IndexCust].name.ToString();
				tbPhone.Text = LoadData.custList[Scheduler.IndexCust].phone.ToString();
				tbAddress.Text = LoadData.custList[Scheduler.IndexCust].address.ToString();
				tbCity.Text = LoadData.custList[Scheduler.IndexCust].city.ToString();
				tbCountry.Text = LoadData.custList[Scheduler.IndexCust].country.ToString();
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			// validate inputs ------------------------------------------------------
			bool validName = ValidateInput.ValidateText(tbName.Text, tbName);
			bool validPhone = ValidateInput.ValidateText(tbPhone.Text, tbPhone);
			bool validAddress = ValidateInput.ValidateText(tbAddress.Text, tbAddress);
			bool validCity = ValidateInput.ValidateText(tbCity.Text, tbCity);
			bool validCountry = ValidateInput.ValidateText(tbCountry.Text, tbCountry);

			if (validName && validPhone && validAddress && validCity && validCountry)
			{
				if (Scheduler.ModifyCust)
				{
					int custId = LoadData.custList[Scheduler.IndexCust].custId;

					var sql = "UPDATE customer, address, city, country SET customer.customerName=@name, address.phone=@phone, address.address=@address, city.city=@city, country.country=@country WHERE customer.addressId=address.addressId AND address.cityId=city.cityId AND city.countryId=country.countryId AND customer.customerId=@custId";
					MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
					cmd.Parameters.AddWithValue("name", tbName.Text);
					cmd.Parameters.AddWithValue("phone", tbPhone.Text);
					cmd.Parameters.AddWithValue("address", tbAddress.Text);
					cmd.Parameters.AddWithValue("city", tbCity.Text);
					cmd.Parameters.AddWithValue("country", tbCountry.Text);
					cmd.Parameters.AddWithValue("custId", custId.ToString());
					cmd.Prepare();
					cmd.ExecuteNonQuery();

					Close();
				}
				else
				{
					string custName = tbName.Text;
					string address = tbAddress.Text;
					string phone = tbPhone.Text;
					string city = tbCity.Text;
					string country = tbCountry.Text;

					int countryId = InsertMethod.addCountry(country);
					int cityId = InsertMethod.addCity(city, countryId);
					int addressId = InsertMethod.addAddress(address, phone, cityId);
					InsertMethod.addCust(custName, addressId);

					Close();
				}
			}
			else 
			{
				MessageBox.Show("Please enter correct inputs.");
			}
		}

		// validate inputs while being inputed ---------------------------
		private void tbName_TextChanged(object sender, EventArgs e)
		{
			ValidateInput.ValidateText(tbName.Text, tbName);
		}

		private void tbPhone_TextChanged(object sender, EventArgs e)
		{
			ValidateInput.ValidateText(tbPhone.Text, tbPhone);
		}

		private void tbAddress_TextChanged(object sender, EventArgs e)
		{
			ValidateInput.ValidateText(tbAddress.Text, tbAddress);
		}

		private void tbCity_TextChanged(object sender, EventArgs e)
		{
			ValidateInput.ValidateText(tbCity.Text, tbCity);
		}

		private void tbCountry_TextChanged(object sender, EventArgs e)
		{
			ValidateInput.ValidateText(tbCountry.Text, tbCountry);
		}
	}
}
