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

        public Records ParentForm { get; set; }

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
            db = new DatabaseConnection();
            add = false;
            saveBtn.Text = "Update";

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = db.GetAllCities();
            

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
            address2Text.Text = addr2;
            zipText.Text = zipcode;
            comboBox1.SelectedValue = cityId;
            Console.WriteLine("hat");
            


        }

        public void Submit() { 
            if(add)
            {
                try
                {
                    db.addCustomer(_name, _addr, _addr2, _city, _zip, _phone);
                    if(ParentForm != null)
                    {
                        ParentForm.refresh();
                    }
                    this.Close();
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                
            } else
            {
                db.updateCustomer(_id, _name, _addr, _addr2, _city, _zip, _phone);
                if (ParentForm != null)
                {
                    ParentForm.refresh();
                }
                this.Close();

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
            //validation that no important customer data is empty, allows address2 to be empty,
            //and Is not possible to put wrong data in as the city field is a locked dropdown. All other fields are free strings.
            List<string> allValues = new List<string> { _name, _addr, _phone, _city.ToString(), _zip };

            //LINQ and lambda function, throws away the s variable after being used to map over each string and return true or false
            bool allFilled = allValues.All(s => s != "");

            if (allFilled)
            {
                Submit();
            } else
            {
                MessageBox.Show("One or more fields are empty");
            }
            
        }

        private void address2Text_TextChanged(object sender, EventArgs e)
        {
            _addr2 = address2Text.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            _city = (int)comboBox1.SelectedValue;
        }

        private void zipText_TextChanged(object sender, EventArgs e)
        {
            _zip = zipText.Text;
        }
    }
}
