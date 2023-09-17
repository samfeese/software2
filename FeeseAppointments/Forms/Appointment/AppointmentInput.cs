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

        public AppointmentInput(int userId)
        {
            InitializeComponent();
            db = new DatabaseConnection();

            this.userId = userId;

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = db.GetAllCustomersList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _custId = (int)comboBox1.SelectedValue;
        }

        private void Submit()
        {
            DateTime apptTime = new DateTime(_day.Year, _day.Month, _day.Day, _time.Hour, _time.Minute, _time.Second);
            DateTime apptEnd = apptTime.AddHours(1);
            db.addAppointment(_custId, userId, _type, apptTime, apptEnd);
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
        }
    }
}
