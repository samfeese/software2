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
        int custId;
        string type;
        DateTime start;
        int apptId;
   

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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = appointmentData.Rows[e.RowIndex];
                custId = int.Parse(r.Cells["customerId"].Value.ToString());
                type = r.Cells["type"].Value.ToString();
                apptId = int.Parse(r.Cells["appointmentId"].Value.ToString());

                string startStr = r.Cells["start"].Value.ToString();
                start = DateTime.Parse(startStr);
               
            }
            else
            {
                custId = -1;
                type = "";
                start = DateTime.Now;
               
            }
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

            string first = defaultFirstDay.ToString("yyyy-MM-dd HH:mm:ss");
            string last = defaultLastDay.ToString("yyyy-MM-dd HH:mm:ss");

            DataTable ds = db.GetAppointmentRecords(first, last);
            appointmentData.DataSource = ds;
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            AppointmentInput form = new AppointmentInput(userId);
            form.ParentForm = this;
            form.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home home = new Home(userId);
            home.Show();
            Close();
        }

        private void updateApptBtn_Click(object sender, EventArgs e)
        {
            AppointmentInput form = new AppointmentInput(apptId, userId, start, type, custId);
            form.ParentForm = this;
            form.Show();
        }

        private void deleteApptBtn_Click(object sender, EventArgs e)
        {
            db.deleteAppointment(apptId);
            refresh();
        }

        public void refresh()
        {
            db = new DatabaseConnection();
            DataTable ds = db.GetAppointmentRecords();
            appointmentData.DataSource = ds;

            allViewRadio.Checked = true;
            monthViewRadio.Checked = false;
            weekViewRadio.Checked = false;
        }

        private void weekViewRadio_CheckedChanged(object sender, EventArgs e)
        {
            db = new DatabaseConnection();

            DateTime currentTime = DateTime.Now;
            DateTime defaultFirstDay = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
            DateTime defaultLastDay = defaultFirstDay.AddDays(7).AddSeconds(-1);

            string first = defaultFirstDay.ToString("yyyy-MM-dd HH:mm:ss");
            string last = defaultLastDay.ToString("yyyy-MM-dd HH:mm:ss");

            DataTable ds = db.GetAppointmentRecords(first, last);
            appointmentData.DataSource = ds;
        }
    }
}
