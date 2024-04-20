using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
	delegate bool LessThan(DateTime start, DateTime end);
	delegate bool BusinessHour(DateTime a);
	public static class ValidateInput
	{
		public static bool ValidateText(string input, TextBox source) // check that input is a string
		{
			if (int.TryParse(input, out _) || input == "")
			{
				source.BackColor = Color.IndianRed;
				return false;
			}
			else
			{
				source.BackColor = Color.White;
				return true;
			}
		}

		public static bool ValidateNumber(string input, TextBox source) // check that input is an integer
		{
			if (!int.TryParse(input, out _) || input == "")
			{
				source.BackColor = Color.IndianRed;
				return false;
			}
			else 
			{
				source.BackColor = Color.White;
				return true;
			}
		}

		public static bool ValidateAppt(DateTime start, DateTime end, int user)
		{
			// anonymous function to check if one time is less than another. Justified because will check multiple times in this method ValidateAppt
			LessThan lessThan = (a, b) => a <= b; 

			//lambda expression used to create anonymous function to see if time is in business hours. Justified because will check for start and end times
			BusinessHour businessHour = a => (a.Hour < 9 || a.Hour >= 17); 

			if (!lessThan(start, end))
				{
					MessageBox.Show("Please enter a start time that occurs before end time.");
					return false;
				}

			if (businessHour(start)) // check if start time is in business hours (between 9am and 5pm)
			{
				MessageBox.Show("Please enter a start time between 9:00 and 17:00.");
				return false;
			}

			if (businessHour(end)) // check if end time is in business hours
			{
				MessageBox.Show("Please enter a end time between 9:00 and 17:00.");
				return false;
			}

			foreach (apptObject e in LoadData.apptList) // check if appt overlaps with another
			{
				if (user == e.userId)
				{
					if (start >= e.start)
					{
						if (lessThan(start, e.end)) // used delegate function to see if start is less than end time
						{
							MessageBox.Show("Appointment overlaps with existing appointment.");
							return false;
						}
					}
					else // (start < e.start)
					{
						if (end > e.start)
						{
							MessageBox.Show("Appointment overlaps with existing appointment.");
							return false;
						}
					}
				}
			}

			if (start.DayOfWeek.ToString() == "Sunday" || start.DayOfWeek.ToString() == "Saturday")
			{
				MessageBox.Show("Appointment cannot be on the weekend.");
				return false;
			}
			if (end.DayOfWeek.ToString() == "Sunday" || end.DayOfWeek.ToString() == "Saturday")
			{
				MessageBox.Show("Appointment cannot be on the weekend.");
				return false;
			}

			return true; // appt does not overlap
		}

		public static bool ValidateCust(int custId) // check if customer is in database
		{
			foreach (int id in LoadData.custIdList)
			{
				if (id == custId)
				{
					return true;
				}
			}
			MessageBox.Show("Please enter valid customer ID."); // customer not in database
			return false;			
		}
	}
}
