using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeeseAppointments.Model;
using System.Globalization;

namespace FeeseAppointments.Forms
{
	public partial class LoginForm : Form
	{

		string username = "";
		string password = "";

		//Login form localizations are en and de (german)

		string localization = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

		public LoginForm()
		{
			InitializeComponent();
		}


		internal Login login = new Login();



		private void Login_Load(object sender, EventArgs e)
		{
			if (localization == "de")
			{
				UsernameLabel.Text = "nutzername";
				passwordLabel.Text = "passwort";
				loginBtn.Text = "einloggen";
			}
			
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			//Exception Handling for invalid user information with try/catch
			try
			{
				(bool, string, int) result = login.ValidateUser(username, password);
				if (result.Item1 == false && result.Item3 < 0)
				{
					throw new Exception(result.Item2);
				}
				bool hasAppt = login.UpCommingAppt(result.Item3);

                if (hasAppt)
                {
					DialogResult confirmed = MessageBox.Show("You have an Appointment in the next 15 Minutes", "Confirm", MessageBoxButtons.OK);
                    if (confirmed == DialogResult.OK)
                    {
						Home hp = new Home(result.Item3);
						hp.Show();
					}
                } else
                {
					Home homePage = new Home(result.Item3);
					homePage.Show();
				}
				
				//Hide();
			}
			catch (Exception ex)
			{
				if (localization == "de")
				{
					MessageBox.Show("Falsche Anmeldeinformationen, versuchen Sie es erneut.");
				}
				else { MessageBox.Show(ex.Message); }
				
			}
		}

		private void usernameInput_TextChanged(object sender, EventArgs e)
		{
			username = usernameInput.Text;
		}

		private void passwordInput_TextChanged(object sender, EventArgs e)
		{
			password = passwordInput.Text;
		}

	}
}
