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
		public Home()
		{
			InitializeComponent();
		}

		private void recordsBtn_Click(object sender, EventArgs e)
		{
			Records.Records rec = new Records.Records();
			rec.Show();
			Close();
		}

		private void Appointments_Click(object sender, EventArgs e)
		{
			Appointments app = new Appointments();
			app.Show();
			Close();
		}
	}
}
