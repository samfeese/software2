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
    public partial class CustomerForm : Form
    {
        bool add = true;
        string _name;
        string _addr;
        string _phone;
        string _addr2;
        int _city;
        string _zip;

        int _id;
        DatabaseConnection db;
        City[] cities;

        public CustomerForm()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = db.GetAllCities();

        }

        public CustomerForm(int id, string name, string address, string phone, string addr2, int cityId, string zipcode)
        {
            InitializeComponent();
            add = false;
            saveBtn.Text = "Update";

            _name = name;
            _addr = address;
            _phone = phone;
            _id = id;
            _addr2 = addr2;
            _city = cityId;
            _zip = zipcode;

            saveBtn.Text = "Update";

            nameInput.Text = name;
            addressInput.Text = address;
            phoneInput.Text = phone;
            db = new DatabaseConnection();
            comboBox1.DataSource = db.GetAllCities();


        }

        public void Submit() { 
            if(add)
            {
                try
                {

                    db.addCustomer(_name, _addr, _addr2, _city, _zip, _phone);
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                
            } else
            {
                db.updateCustomer(_id, _name, _addr, _phone);
            }
            
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            _name = nameInput.Text;
        }

        private void addressInput_TextChanged(object sender, EventArgs e)
        {
            _addr = addressInput.Text;
        }

        private void phoneInput_TextChanged(object sender, EventArgs e)
        {
            _phone = phoneInput.Text;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void address2Text_TextChanged(object sender, EventArgs e)
        {
            _addr2 = address2Text.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            _city = int.Parse(comboBox1.SelectedValue.ToString());
        }

        private void zipText_TextChanged(object sender, EventArgs e)
        {
            _zip = zipText.Text;
        }
    }
}
