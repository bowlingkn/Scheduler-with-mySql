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
	public partial class Scheduler : Form
	{
		public Scheduler()
		{
			InitializeComponent();
		}

		public static bool ModifyAppt { get; set; }
		public static int IndexAppt { get; set; }
		public static bool ModifyCust { get; set; }
		public static int IndexCust { get; set; }



		// get data from database --------------------------------------------------------
		private void Scheduler_Activated(object sender, EventArgs e)
		{
			// need to JOIN if want username instead of id
			LoadData.loadAppt();
			LoadData.loadCust();
			dgvAppt.DataSource = LoadData.apptList;
			dgvCustomer.DataSource = LoadData.custList;
			ModifyAppt = false;
			ModifyCust = false;

			// list of all usernames and customer names for reports
			cbType.DataSource = LoadData.typeList;
			cbUser.DataSource = LoadData.userList;
			cbCustomer.DataSource = LoadData.custIdList;

		}

		// show all appointments 
		private void buttonAll_Click(object sender, EventArgs e)
		{
			LoadData.loadAppt();
			dgvAppt.DataSource = LoadData.apptList;
		}

		// show this week appointments
		private void buttonWeekly_Click(object sender, EventArgs e)
		{
			DateTime currentDate = DateTime.UtcNow.Date;

			LoadData.loadWeek(currentDate);
			dgvAppt.DataSource = LoadData.apptList;
		}

		// show this month appointments
		private void buttonMonthly_Click(object sender, EventArgs e)
		{
			DateTime currentDate = DateTime.UtcNow.Date;

			LoadData.loadMonth(currentDate);
			dgvAppt.DataSource = LoadData.apptList;
		}

		// add appointment and customer -----------------------------------------------------------
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			appointment appointmentForm = new appointment();
			appointmentForm.Show();
		}
		private void buttonAdd2_Click(object sender, EventArgs e)
		{
			customer customerForm = new customer();
			customerForm.Show();
		}
	
		// modify appointment ----------------------------------------------
		private void buttonModify_Click(object sender, EventArgs e)
		{
			if (!dgvAppt.CurrentRow.Selected)
			{
				MessageBox.Show("Please select an appointment.");
				return;
			}
			ModifyAppt = true;
			IndexAppt = dgvAppt.CurrentRow.Index;
			appointment appointmentForm = new appointment();
			appointmentForm.Show();
		}
		private void buttonModify2_Click(object sender, EventArgs e)
		{
			if (!dgvCustomer.CurrentRow.Selected)
			{
				MessageBox.Show("Please select an appointment.");
				return;
			}
			ModifyCust = true;
			IndexCust = dgvCustomer.CurrentRow.Index;
			customer customerForm = new customer();
			customerForm.Show();

		}

		// delete appointment ------------------------------------------------
		private void buttonDelete1_Click(object sender, EventArgs e)
		{
			if (!dgvAppt.CurrentRow.Selected)
			{
				MessageBox.Show("Please select an appointment.");
				return;
			}
			IndexAppt = dgvAppt.CurrentRow.Index;

			try
			{
				var sql = "DELETE FROM appointment WHERE appointmentId = @apptId";
				MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
				cmd.Parameters.AddWithValue("apptId", LoadData.apptList[IndexAppt].apptId);
				cmd.Prepare();
				cmd.ExecuteNonQuery();
				LoadData.loadAppt();
				dgvAppt.DataSource = LoadData.apptList;
			}
			catch
			{
				MessageBox.Show("Appointment cannot be deleted.");
			}
		}

		// delete customer ------------------------------------------------
		private void buttonDelete2_Click(object sender, EventArgs e)
		{
			if (!dgvCustomer.CurrentRow.Selected)
			{
				MessageBox.Show("Please select an customer.");
				return;
			}
			IndexCust = dgvCustomer.CurrentRow.Index;

			try
			{
				int addressId = DeleteMethod.deleteCustomer(LoadData.custList[IndexCust].custId);
				int cityId = DeleteMethod.deleteAddress(addressId);
				int countryId = DeleteMethod.deleteCity(cityId);
				DeleteMethod.deleteCountry(countryId);
			}
			catch
			{
				MessageBox.Show("Cannot delete customer associated with an appointment.");
			}

			LoadData.loadCust();
			dgvCustomer.DataSource = LoadData.custList;
		}

		// reports -----------------------------------------------------------
		private void buttonReport1_Click(object sender, EventArgs e)  // number of appts by type and month
		{
			if (cbMonth.Text == "" || cbYear.Text == "")
			{
				MessageBox.Show("Please select an option.");
			}
			else
			{
				int dateMonth = cbMonth.SelectedIndex + 1;
				int dateYear = Convert.ToInt32(cbYear.Text);
				DateTime chosenDate = new DateTime(dateYear, dateMonth, 1);
				string apptType = cbType.Text;

				string sql = "SELECT COUNT(*) FROM appointment WHERE type=@type AND start >= @start AND start < @end";
				MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
				cmd.Parameters.AddWithValue("type", apptType);
				cmd.Parameters.AddWithValue("start", chosenDate);
				cmd.Parameters.AddWithValue("end", chosenDate.AddMonths(1));
				cmd.Prepare();
				int total = Convert.ToInt32(cmd.ExecuteScalar());

				tbReport.Text = $"There are {total} appointments of that type";
			}
		}

		private void buttonReport2_Click(object sender, EventArgs e) // list of appts by selected user
		{
			string sql = "SELECT user.userName, appointment.start, appointment.type FROM user INNER JOIN appointment ON user.userId=appointment.userId WHERE userName = @username";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("username", cbUser.Text);
			MySqlDataReader reader = cmd.ExecuteReader();
			BindingList<apptObject> userApptList = new BindingList<apptObject>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					userApptList.Add(new apptObject(reader.GetString(0), reader.GetDateTime(1).ToLocalTime(), reader.GetString(2)));
				}
			}
			else
			{
				reader.Close();
				MessageBox.Show("No appointments found.");
			}

			dgvReport.DataSource = userApptList;
			for (int i = 0; i < dgvReport.Columns.Count; i++)
			{
				dgvReport.Columns[i].Visible = false;
			}

			dgvReport.Columns[0].Visible = true;
			dgvReport.Columns[1].Visible = true;
			dgvReport.Columns[3].Visible = true;

			reader.Close();

		}

		private void buttonReport3_Click(object sender, EventArgs e) // list of appts by selected customer
		{
			string sql = "SELECT customerId, start, type FROM appointment WHERE customerId = @custId";
			MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
			cmd.Parameters.AddWithValue("custId", cbCustomer.Text);
			MySqlDataReader reader = cmd.ExecuteReader();
			BindingList<apptObject> custApptList = new BindingList<apptObject>();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					custApptList.Add(new apptObject(reader.GetInt32(0), reader.GetDateTime(1).ToLocalTime(), reader.GetString(2)));
				}
			}
			else
			{
				reader.Close();
				MessageBox.Show("No appointments found.");
			}

			dgvReport.DataSource = custApptList;
			for (int i = 0; i < dgvReport.Columns.Count; i++)
			{
				dgvReport.Columns[i].Visible = false;
			}

			dgvReport.Columns[4].Visible = true;
			dgvReport.Columns[1].Visible = true;
			dgvReport.Columns[3].Visible = true;

			reader.Close();
		}


		// closing application -----------------------------------------------
		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Scheduler_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// check if user has appt within 15 minutes of login ------------------
		private void Scheduler_Shown(object sender, EventArgs e)
		{
			LoadData.loadAppt();
			LoadData.loadCust();
			dgvAppt.DataSource = LoadData.apptList;
			dgvCustomer.DataSource = LoadData.custList;
			DateTime current = DateTime.Now;
			

			for (int i = 0; i < LoadData.apptList.Count; i++)
			{
				if ((LoadData.apptList[i].start >= current) && (LoadData.apptList[i].start <= current.AddMinutes(15)))
				{
					if (Login.user == LoadData.apptList[i].username)
					{
						MessageBox.Show("You have an appointment in the next 15 minutes.");
					}
				}
			}
		}
	}
}
