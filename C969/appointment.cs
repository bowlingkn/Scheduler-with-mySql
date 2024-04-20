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
	public partial class appointment : Form
	{
		public appointment()
		{
			InitializeComponent();
			dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			dtpEnd.CustomFormat ="yyyy-MM-dd HH:mm:ss";

			if (Scheduler.ModifyAppt)
			{
				dtpStart.Text = LoadData.apptList[Scheduler.IndexAppt].start.ToString();
				dtpEnd.Text = LoadData.apptList[Scheduler.IndexAppt].end.ToString();
				tbType.Text = LoadData.apptList[Scheduler.IndexAppt].type;
				tbCustomer.Text = LoadData.apptList[Scheduler.IndexAppt].customerId.ToString();
				tbUser.Text = LoadData.apptList[Scheduler.IndexAppt].userId.ToString();
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			// validate inputs, check for overlapping appts, check that customer exists ----------------------
			bool validCust = ValidateInput.ValidateNumber(tbCustomer.Text, tbCustomer);
			bool validUser = ValidateInput.ValidateNumber(tbUser.Text, tbUser);
			bool validType = ValidateInput.ValidateText(tbType.Text, tbType);
			bool validAppt = ValidateInput.ValidateAppt(dtpStart.Value, dtpEnd.Value, Convert.ToInt32(tbUser.Text));
			bool validCustId = ValidateInput.ValidateCust(Convert.ToInt32(tbCustomer.Text));

			if (validCust && validUser && validType && validAppt && validCustId)
			{
				if (Scheduler.ModifyAppt)
				{
					int apptId = LoadData.apptList[Scheduler.IndexAppt].apptId;

					var sql = "UPDATE appointment SET customerId=@customer, userId=@user, type=@type, start=@start, end=@end WHERE appointmentId=@apptId";
					MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
					cmd.Parameters.AddWithValue("customer", Convert.ToInt32(tbCustomer.Text));
					cmd.Parameters.AddWithValue("user", Convert.ToInt32(tbUser.Text));
					cmd.Parameters.AddWithValue("type", tbType.Text);
					cmd.Parameters.AddWithValue("start", dtpStart.Value);
					cmd.Parameters.AddWithValue("end", dtpEnd.Value);
					cmd.Parameters.AddWithValue("apptId", apptId.ToString());
					cmd.Prepare();
					cmd.ExecuteNonQuery();

					Close();
				}
				else
				{
					int appointmentId = 0; // database will auto assign once uploaded
					int customerId, userId, createBy, lastUpdateBy;
					string type;
					DateTime start, end, create, lastUpdate;

					customerId = Convert.ToInt32(tbCustomer.Text);
					userId = Convert.ToInt32(tbUser.Text);
					type = tbType.Text;
					start = dtpStart.Value.ToUniversalTime();
					end = dtpEnd.Value.ToUniversalTime();
					create = DateTime.UtcNow;
					createBy = Convert.ToInt32(tbUser.Text); 
					lastUpdate = DateTime.UtcNow;
					lastUpdateBy = Convert.ToInt32(tbUser.Text);


					var sql = "INSERT INTO appointment VALUES (@appointmentId, @customerId, @userId, 'n/a', 'n/a', 'n/a', 'n/a', @type, 'n/a', @start, @end, @created, @createdBy, @lastUpdate, @lastUpdateby)";
					MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
					cmd.Parameters.AddWithValue("appointmentId", appointmentId);
					cmd.Parameters.AddWithValue("customerId", customerId);
					cmd.Parameters.AddWithValue("userId", userId);
					cmd.Parameters.AddWithValue("type", type);
					cmd.Parameters.AddWithValue("start", start);
					cmd.Parameters.AddWithValue("end", end);
					cmd.Parameters.AddWithValue("created", create);
					cmd.Parameters.AddWithValue("createdBy", createBy);
					cmd.Parameters.AddWithValue("lastUpdate", lastUpdate);
					cmd.Parameters.AddWithValue("lastUpdateBy", lastUpdateBy);
					cmd.Prepare();
					cmd.ExecuteNonQuery();

					Close();
				}
			}
			else 
			{
				MessageBox.Show("Please enter correct inputs.");
			}
		}

		// validate inputs ----------------------------------------------------------
		private void tbCustomer_TextChanged(object sender, EventArgs e)
		{
			ValidateInput.ValidateNumber(tbCustomer.Text, tbCustomer);
		}

		private void tbUser_TextChanged(object sender, EventArgs e)
		{
			ValidateInput.ValidateNumber(tbUser.Text, tbUser);
		}

		private void tbType_TextChanged(object sender, EventArgs e)
		{
			ValidateInput.ValidateText(tbType.Text, tbType);
		}
	}
}
