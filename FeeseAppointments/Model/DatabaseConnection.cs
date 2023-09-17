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
			}
			catch(Exception e) {
				throw new Exception(e.Message);
			}
			con.Close();

		}

		public int GetUserCredentials(string uname, string pass)
		{
			string sqlUser = $"SELECT * FROM user WHERE userName='{uname}' AND password='{pass}';";
			try
			{
				con.Open();
				MySqlCommand cmd = new MySqlCommand(sqlUser, con);
				int uId = Convert.ToInt32(cmd.ExecuteScalar());
			
				if (uId >= 0) {
			
					con.Close();
					return uId;
				}
				con.Close();
				return -1;
			}
			catch(Exception e)
			{
				con.Close();
				throw new Exception(e.Message);
			}
			
		}

		public DataTable GetCustomerRecords() {
			string getAllCustomers = "SELECT c.customerId, c.customerName, a.address, a.address2, a.cityId, a.postalCode, a.phone FROM customer AS c JOIN address AS a ON c.addressId=a.addressId;";
			try
			{
				DataTable ds = new DataTable();
				con.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(getAllCustomers, con);

				da.Fill(ds);
				con.Close();
				return ds;
			}
			catch (Exception e) {
				MessageBox.Show(e.Message);
			}
			con.Close();
			return null;

        }

		public DataTable GetAppointmentRecords()
        {
			string getAllAppointments = "SELECT a.type, a.start, a.end, c.customerName, a.userId, a.customerId FROM appointment AS a JOIN customer AS c ON a.customerId=c.customerId;";
			try
			{
				DataTable ds = new DataTable();
				con.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(getAllAppointments, con);

				da.Fill(ds);
				con.Close();
				return ds;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			con.Close();
			return null;
		}

		public DataTable GetAppointmentRecords(DateTime start, DateTime end)
		{
			string getAllAppointments = "SELECT a.type, a.start, a.end, c.customerName, a.userId, a.customerId FROM appointment AS a JOIN customer AS c ON a.customerId=c.customerId;";
			try
			{
				DataTable ds = new DataTable();
				con.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(getAllAppointments, con);

				da.Fill(ds);


				//lambda function, i dont need the variable r, just the result from each interation in the where clause.
				var filteredRows = ds.AsEnumerable().Where(r => { 
					
					DateTime startAt = r.Field<DateTime>("start");
					DateTime endAt = r.Field<DateTime>("end");

					return startAt >= start && startAt <= end && endAt >= start && endAt <= end;
				});

				ds.Rows.Clear();
				foreach(DataRow row in filteredRows)
                {
					ds.ImportRow(row);
                }
				con.Close();
				return ds;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			con.Close();
			return null;
		}


		public City[] GetAllCities()
        {
			City temp;
			List<City> cities = new List<City> { };
			string getCityValues = "SELECT cityId, city FROM city;";
			
			
			try
            {
				con.Open();
				MySqlCommand cmd = new MySqlCommand(getCityValues, con);
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
                {

					temp = new City { ID = reader.GetInt32(0), Name = reader.GetString(1) };
					cities.Add(temp);
                }
				reader.Close();	
            }
            catch (Exception e)
            {
				MessageBox.Show(e.Message);
				
            }
			con.Close();
			return cities.ToArray();
		}
		public Customer[] GetAllCustomersList()
		{
			Customer temp;
			List<Customer> customers = new List<Customer> { };
			string getCustomerValues = "SELECT customerId, customerName FROM customer;";


			try
			{
				con.Open();
				MySqlCommand cmd = new MySqlCommand(getCustomerValues, con);
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					temp = new Customer { ID = reader.GetInt32(0), Name = reader.GetString(1) };
					customers.Add(temp);
				}
				reader.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);

			}
			con.Close();
			return customers.ToArray();
		}


		public void addCustomer(string name, string addr, string addr2, int city, string zip, string phone) {
			long addrId;
			
			string addPhoneAndAddr = $"INSERT INTO address(address, phone, address2, cityId, postalCode, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES('{addr}', '{phone}', '{addr2}', {city}, '{zip}', NOW(), 'test', NOW(), 'test');";

			
				try
				{
					con.Open();
					MySqlCommand addressCmd = new MySqlCommand(addPhoneAndAddr, con);
					addressCmd.ExecuteNonQuery();
					addrId = addressCmd.LastInsertedId;
					
					if (addrId >= 0)
					{
						string addCustomer = $"INSERT INTO customer(customerName, addressId, active, lastUpdate, lastUpdateBy, createDate, createdBy) VALUES('{name}', {addrId}, 1, NOW(), 'test', NOW(), 'test');";
						MySqlCommand customerCmd = new MySqlCommand(addCustomer, con);
						customerCmd.ExecuteNonQuery();
					}
					else { throw new Exception("address id can not be found"); }
					

				}

				catch (Exception e)
				{
					throw new Exception(e.Message);
				}
			con.Close();
			
		}

		public void updateCustomer(int id, string name, string addr, string addr2, int city, string zip, string phone)
		{
			string updateCustomer = $"UPDATE customer SET customerName='{name}' WHERE customerId={id};";
			string updatePhoneAndAddr = $"UPDATE address SET address='{addr}', phone='{phone}', address2='{addr2}', cityId={city}, postalCode='{zip}' " +
				$"WHERE addressId=(SELECT addressId FROM customer WHERE customerId={id});";

			
			try
			{
				con.Open();
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
		public void deleteCustomer(int id)
        {
			string deleteQuery = $"DELETE FROM customer WHERE customerId={id};";
			try
            {
				con.Open();
				MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con);
				deleteCmd.ExecuteNonQuery();
            }
			catch (Exception e)
            {
				MessageBox.Show(e.Message);
            }
			con.Close();

		}

		public void addAppointment(int custId, int userId, string type, DateTime start, DateTime end)
		{
			//INSERT INTO appointment(customerId, userId, type, start, end) VALUES(1, 1, 'hat', '2019-01-01 00:00:00', '2019-01-01 00:00:00'); works except it will need to default all of the feilds that dont matter.
			string addApptQuery = $"INSERT INTO appointment(custumerId, userId, type, start, end) VALUES({custId}, {userId}, {type}, {start}, {end});";
			try
			{
				con.Open();
				MySqlCommand apptCmd = new MySqlCommand(addApptQuery, con);
				apptCmd.ExecuteNonQuery();
			}

			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
			con.Close();
		}

	}
}
