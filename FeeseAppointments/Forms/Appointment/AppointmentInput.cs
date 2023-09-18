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

namespace FeeseAppointments.Forms.Appointment
{
    public partial class AppointmentInput : Form
    {
        DatabaseConnection db;
        string _type;
        DateTime _time;
        DateTime _day;
        int _custId;
        int userId;
        int _apptId;

        bool isUpdateing = false;
        public Appointments ParentForm { get; set; }

        public AppointmentInput(int userId)
        {
            InitializeComponent();
            db = new DatabaseConnection();

            this.userId = userId;

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = db.GetAllCustomersList();

            _time = DateTime.Now;
            _day = DateTime.Now;
        }
        public AppointmentInput(int apptId, int userId, DateTime time, string type, int custId)
        {
            InitializeComponent();
            db = new DatabaseConnection();

            this.userId = userId;

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = db.GetAllCustomersList();

            _time = time;
            _day = time;
            _type = type;
            _custId = custId;
            _apptId = apptId;

            typeInput.Text = type;
            comboBox1.SelectedValue = custId;
            monthCalendar1.SelectionStart = time;
            dateTimePicker1.Value = time;
            addApptBtn.Text = "Update";

            isUpdateing = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _custId = (int)comboBox1.SelectedValue;
        }

        private void Submit()
        {
            DateTime apptTime = new DateTime(_day.Year, _day.Month, _day.Day, _time.Hour, _time.Minute, _time.Second).ToUniversalTime();
            DateTime apptEnd = apptTime.AddHours(1).ToUniversalTime();
            string mySqlStart = apptTime.ToString("yyyy-MM-dd HH:mm:ss");
            string mySqlEnd = apptEnd.ToString("yyyy-MM-dd HH:mm:ss");
            if (isUpdateing)
            {
                db.updateAppointment(_apptId, _custId, userId, _type, mySqlStart, mySqlEnd);
            } else
            {
                db.addAppointment(_custId, userId, _type, mySqlStart, mySqlEnd);
            }
           
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _time = dateTimePicker1.Value;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            _day = monthCalendar1.SelectionStart;
        }

        private void typeInput_TextChanged(object sender, EventArgs e)
        {
            _type = typeInput.Text;
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            Submit();
            ParentForm.refresh();
            Close();
        }
    }
}
