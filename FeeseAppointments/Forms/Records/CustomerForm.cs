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

        int _id;
        DatabaseConnection db;

        public CustomerForm()
        {
            InitializeComponent();
           
        }

        public CustomerForm(int id, string name, string address, string phone)
        {
            InitializeComponent();
            add = false;
            saveBtn.Text = "Update";

            _name = name;
            _addr = address;
            _phone = phone;
            _id = id;

            saveBtn.Text = "Update";

            nameInput.Text = name;
            addressInput.Text = address;
            phoneInput.Text = phone;

            db = new DatabaseConnection();
        }

        public void Submit() { 
            if(add)
            {
                db.addCustomer(_name, _addr, _phone);
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
    }
}
