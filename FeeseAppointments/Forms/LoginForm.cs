﻿using System;
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
			//Exception Handling for invalid user information
			try
			{
				(bool, string) result = login.ValidateUser(username, password);
				if (result.Item1 == false)
				{
					throw new Exception(result.Item2);
				}
				Home homePage = new Home();
				homePage.Show();
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