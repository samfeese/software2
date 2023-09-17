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
    public partial class Appointments : Form
    {
        DatabaseConnection db;
        int userId;
        public Appointments(int userId)
        {
            InitializeComponent();
            this.userId = userId;

        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            db = new DatabaseConnection();
            DataTable ds = db.GetAppointmentRecords();
            appointmentData.DataSource = ds;
        }

        private void appointmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allViewRadio_CheckedChanged(object sender, EventArgs e)
        {
            db = new DatabaseConnection();
            DataTable ds = db.GetAppointmentRecords();
            appointmentData.DataSource = ds;
        }

        private void monthViewRadio_CheckedChanged(object sender, EventArgs e)
        {
            db = new DatabaseConnection();

            DateTime currentTime = DateTime.Now;
            DateTime defaultFirstDay = new DateTime(currentTime.Year, currentTime.Month, 1, 0, 0, 0);
            DateTime defaultLastDay = defaultFirstDay.AddMonths(1).AddSeconds(-1);

            DataTable ds = db.GetAppointmentRecords(defaultFirstDay, defaultLastDay);
            appointmentData.DataSource = ds;
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            AppointmentInput form = new AppointmentInput(userId);
            form.Show();
        }
    }
}
