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
			string getAllAppointments = "SELECT a.appointmentId, a.type, a.start, a.end, c.customerName, a.userId, a.customerId FROM appointment AS a JOIN customer AS c ON a.customerId=c.customerId;";
			try
			{
				DataTable ds = new DataTable();
				con.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(getAllAppointments, con);

				da.Fill(ds);


				//lambda/LINQ used to iterate over each row and making the times local for the user. The variable row is just used as an iterator, and the return value is what is important.
				ds.AsEnumerable().ToList().ForEach(row =>
				{
					if (row["start"] != DBNull.Value)
					{
						DateTime startUtc = row.Field<DateTime>("start");
						row.SetField("start", startUtc.ToLocalTime());
					}

					if (row["end"] != DBNull.Value)
					{
						DateTime endUtc = row.Field<DateTime>("end");
						row.SetField("end", endUtc.ToLocalTime());
					}
				});

				con.Close();
				return ds;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				con.Close();
			}
			return null;
		}

		public DataTable GetAppointmentRecords(string start, string end)
		{
			string getAllAppointments = $"SELECT a.appointmentId, a.type, a.start, a.end, c.customerName, a.userId, a.customerId FROM appointment AS a JOIN customer AS c ON a.customerId=c.customerId WHERE a.start BETWEEN '{start}' AND '{end}';";
			try
			{
				DataTable ds = new DataTable();
				con.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(getAllAppointments, con);

				da.Fill(ds);

				//lambda/LINQ used to iterate over each row and making the times local for the user. The variable r is just used as an iterator, and the return value is what is important.
				ds.AsEnumerable().ToList().ForEach(r =>
				{
					if (r["start"] != DBNull.Value)
					{
						DateTime utc = r.Field<DateTime>("start");
						r.SetField("start", utc.ToLocalTime());
					}

					if (r["end"] != DBNull.Value)
					{
						DateTime utc = r.Field<DateTime>("end");
						r.SetField("end", utc.ToLocalTime());
					}
				});

				con.Close();
				return ds;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				con.Close();
			}
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

		public void addAppointment(int custId, int userId, string type, string start, string end)
		{
			//INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
			//VALUES(1, 1, 'not needed', 'not needed', 'not needed', 'not needed', 'TYPE', 'not needed', '2019-01-01 00:00:00', '2019-01-01 00:00:00', NOW(), 'test', NOW(), 'test');  works except it will need to default all of the feilds that dont matter.
			string addApptQuery = $"INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES({custId}, {userId}, 'not needed', 'not needed', 'not needed', 'not needed', '{type}', 'not needed', '{start}', '{end}', NOW(), 'test', NOW(), 'test'); ";

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

		public void updateAppointment(int apptId, int custId, int userId, string type, string start, string end)
        {
			string updateAppt = $"UPDATE appointment SET customerId={custId}, userId={userId}, type='{type}', start='{start}', end='{end}' WHERE appointmentId={apptId};";

			try
			{
				con.Open();
				MySqlCommand update = new MySqlCommand(updateAppt, con);
				update.ExecuteNonQuery();
			}

			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			con.Close();
		}

		public void deleteAppointment(int id)
		{
			string deleteQuery = $"DELETE FROM appointment WHERE appointmentId={id};";
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

		public int checkFor15Minutes(int userId)
        {
			DateTime startTime = DateTime.Now;
			string startStr = startTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
			string next15Min = startTime.AddMinutes(15).ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
			string select15 = $"Select COUNT(*) FROM appointment WHERE userId={userId} AND start BETWEEN '{startStr}' AND '{next15Min}';";

			try
			{
				con.Open();
				MySqlCommand cmd = new MySqlCommand(select15, con);
				int count = Convert.ToInt32(cmd.ExecuteScalar());
				return count;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				con.Close();
			}
			return 0;
		}

	}
}
