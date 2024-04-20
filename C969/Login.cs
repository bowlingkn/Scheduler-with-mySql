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
	public partial class Login : Form
	{
		public static string user { get; set; }
		public Login()
		{
			InitializeComponent();
			string location = System.Globalization.CultureInfo.CurrentCulture.DisplayName;
			string region = System.Globalization.CultureInfo.CurrentCulture.Name;

			labelLocation.Text = $"Current location: {location}";

			// Spain region --------------------------------------------------------
			if (region == "es-ES")
			{
				labelUsername.Text = "Usuario";
				labelPassword.Text = "Contrasena";
				buttonSubmit.Text = "Someter";
			}
			if (region == "fr-FR")
			{
				labelUsername.Text = "Nom";
				labelPassword.Text = "Mot de passe";
				buttonSubmit.Text = "Soumettre";
			}
		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			string region = System.Globalization.CultureInfo.CurrentCulture.Name;
			DateTime loginDateTime = DateTime.UtcNow;
			user = tbUsername.Text;

			if (ValidateInput.ValidateText(tbUsername.Text, tbUsername) &&
				ValidateInput.ValidateText(tbPassword.Text, tbPassword))
			{
				string password = tbPassword.Text;

				string sql = "SELECT password FROM user WHERE username = @username";
				MySqlCommand cmd = new MySqlCommand(sql, DBConnection.connection);
				cmd.Parameters.AddWithValue("username", user);
				cmd.Prepare();

				MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						if (reader["password"].ToString() == password)
						{
							reader.Close();

						// log user login time ---------------------------------
						TrackLogin.trackSuccess(user, loginDateTime);

						// open main scheduler window ---------------------------
						Hide();
						Scheduler scheduler = new Scheduler();
						scheduler.Show();
						}

						else
						{
							TrackLogin.trackFail(user, loginDateTime);

						if (region == "es-ES") // Spain
						{
							MessageBox.Show("La clave no coincide con el nombre de usuario");
						}
						else if (region == "fr-FR") // France
						{
							MessageBox.Show("Le mot de passe ne correspond pas au nom");
						}
						else
						{
							MessageBox.Show("Password does not match.");
						}
						}
					}
					else
					{
						TrackLogin.trackFail(user, loginDateTime);

					if (region == "es-ES") // Spain
					{
						MessageBox.Show("Nombre de usuario no encontrado");
					}
					else if (region == "fr-FR")
					{
						MessageBox.Show("Nom introuvable");
					}
					else
					{
						MessageBox.Show("Username not found.");
					}
					
					}
				
				reader.Close();
			
			}	
			else
			{
				TrackLogin.trackFail(user, loginDateTime);

				if (region == "es-ES") // Spain
				{
					MessageBox.Show("Por favor introduza un nombre de usuario y una contrasena validos");
				}
				else if (region == "fr-FR")
				{
					MessageBox.Show("Veuillez entrer un nom et unmot de passe valides");
				}
				else
				{
					MessageBox.Show("please enter valid username and password");
				}
 			}	
		}
	}
}
