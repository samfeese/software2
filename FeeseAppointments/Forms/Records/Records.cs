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

namespace FeeseAppointments.Forms.Records
{
	public partial class Records : Form
	{
		int id;
		string selectedName;
		string selectedAddr;
		string selAddr2;
		int selCity;
		string selZip;
		string selectedPhone;

		private DatabaseConnection db;

		int userId;

		public Records(int userId)
		{
			InitializeComponent();
			addCustomer.Enabled = true;
			updateCustomer.Enabled = true;
			deleteCustomer.Enabled = true;

			this.userId = userId;
		}

		private void Records_Load(object sender, EventArgs e)
		{
			db = new DatabaseConnection();
			DataTable ds = db.GetCustomerRecords();
			dataGridView1.DataSource = ds;
		}

		private void Home_Click(object sender, EventArgs e)
        {
			Home home = new Home(userId);
			home.Show();
			Close();
        }

        private void addCustomer_Click(object sender, EventArgs e)
		{ 
			CustomerForm cust = new CustomerForm();
			cust.ParentForm = this;
			cust.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			if(e.RowIndex >= 0)
            {
				updateCustomer.Enabled = true;
				deleteCustomer.Enabled = true;
				DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
				id = int.Parse(r.Cells["customerId"].Value.ToString());
				selectedName = r.Cells["customerName"].Value.ToString();
				selectedAddr = r.Cells["address"].Value.ToString();
				selAddr2 = r.Cells["address2"].Value.ToString();
				selCity = int.Parse(r.Cells["cityId"].Value.ToString());
				selZip = r.Cells["postalCode"].Value.ToString();
				selectedPhone = r.Cells["phone"].Value.ToString();
			} else
            {
				id = -1;
				selectedPhone = "";
				selectedName = "";
				selectedAddr = "";
            }
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
			if (id >= 0)
			{
				CustomerForm cust = new CustomerForm(id, selectedName, selectedAddr, selectedPhone, selAddr2, selCity, selZip);
				cust.ParentForm = this;
				cust.Show();
			}
			else {
				MessageBox.Show("Please Select a Row to Update.");
			}
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
			if (id >= 0)
			{
                try
                {
					db.deleteCustomer(id);
					this.refresh();
				} catch (Exception ex)
                {
					MessageBox.Show(ex.Message);
                }
				
			}
			else
			{
				MessageBox.Show("Please Select a Row to Delete.");
			}
		}

		public void refresh()
        {
			db = new DatabaseConnection();
			DataTable ds = db.GetCustomerRecords();
			dataGridView1.DataSource = ds;
		}
    }
}
