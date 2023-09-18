using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FeeseAppointments.Model
{
	class Login
	{

		public string Username { get; set; }
		public string Password { get; set; }

		private DatabaseConnection db;
	
		public Login()
		{
			Username = "";
			Password = "";
			db = new DatabaseConnection();
		}
		
		public (bool, string, int) ValidateUser(string username, string password)
		{
		
			if (username == "" || password == "")
			{
				return (false, "You must input values into all fields", -1);
			}
			
			int result = db.GetUserCredentials(username, password);

			if (result < 0) {
				return (false, "Incorrect credentials, try again.", -1);
			}

			return (true, "", result);
			
		}

		public bool UpCommingAppt(int user)
        {
			int result = db.checkFor15Minutes(user);
			if (result > 0)
			{
				return true;
			}
			else { return false; }
			
        }

	}
}
