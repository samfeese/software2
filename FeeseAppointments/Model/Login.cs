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
		
		public (bool, string) ValidateUser(string username, string password)
		{
		
			if (username == "" || password == "")
			{
				return (false, "You must input values into all fields");
			}
			
			bool result = db.GetUserCredentials(username, password);

			if (result == false) {
				return (false, "Incorrect credentials, try again.");
			}

			return (true, "");
			
		}

	}
}
