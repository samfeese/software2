using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeeseAppointments.Forms.Records;

namespace FeeseAppointments.Forms
{
	public partial class Home : Form
	{
		int userId;
		public Home(int userId)
		{
			InitializeComponent();
			this.userId = userId;
		}

		private void recordsBtn_Click(object sender, EventArgs e)
		{
			Records.Records rec = new Records.Records(userId);
			rec.Show();
			Close();
		}

		private void Appointments_Click(object sender, EventArgs e)
		{
			Appointment.Appointments app = new Appointment.Appointments(userId);
			app.Show();
			Close();
		}
	}
}
