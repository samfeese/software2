using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FeeseAppointments.Model
{
	public class DatabaseConnection
	{
		private string mysqlConnection;
		private MySqlConnection con; 

		public DatabaseConnection() { 
			mysqlConnection = "server=localhost;database=client_schedule;uid=sqlUser;pwd=Passw0rd!;";
			con = new MySqlConnection(mysqlConnection);
			TestConnection();
		}


		public void TestConnection() {
			try {
				con.Open();
				con.Close();
			}
			catch(Exception e) {
				throw new Exception(e.Message);
			}

		}

		public bool GetUserCredentials(string uname, string pass)
		{
			string sqlUser = $"SELECT * FROM user WHERE userName='{uname}' AND password='{pass}';";
			try
			{
				con.Open();
				MySqlCommand cmd = new MySqlCommand(sqlUser, con);
				MySqlDataReader reader = cmd.ExecuteReader();
				
				if (reader.HasRows) {
					return true;
				}

				con.Close();
				return false;
			}
			catch(Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public DataTable GetCustomerRecords() {
			string getAllCustomers = "SELECT c.customerId, c.customerName, a.address, a.phone FROM customer AS c JOIN address AS a ON c.addressId=a.addressId;";
			try
			{
				DataTable ds = new DataTable();
				con.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(getAllCustomers, con);
				da.Fill(ds);
				return ds;
			}
			catch (Exception e) {
				MessageBox.Show(e.Message);
			}
			con.Close();
			return null;

        }

		public void addCustomer(string name, string addr, string phone) {
			string addCustomer = $"INSERT INTO customer(customerName) VALUES('{name}');";
			string addPhoneAndAddr = $"INSERT INTO address(address, phone) VALUES('{addr}', '{phone}');";

			con.Open();
				try
				{
					MySqlCommand customerCmd = new MySqlCommand(addCustomer, con);
					MySqlCommand addressCmd = new MySqlCommand(addPhoneAndAddr, con);
					customerCmd.ExecuteNonQuery();
					addressCmd.ExecuteNonQuery();
				}

				catch (Exception e)
				{
					MessageBox.Show(e.Message);
				}
			con.Close();
			
		}

		public void updateCustomer(int id, string name, string addr, string phone)
		{
			string updateCustomer = $"UPDATE customer SET customerName='{name}' WHERE customerId={id};";
			string updatePhoneAndAddr = $"UPDATE address SET address='{addr}', phone='{phone}' " +
				$"WHERE addressId=(SELECT addressId FROM customer WHERE customerId={id});";

			con.Open();
			try
			{
				MySqlCommand customerCmd = new MySqlCommand(updateCustomer, con);
				MySqlCommand addressCmd = new MySqlCommand(updatePhoneAndAddr, con);
				customerCmd.ExecuteNonQuery();
				addressCmd.ExecuteNonQuery();
			}

			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			con.Close();

		}

	}

	

	

}
