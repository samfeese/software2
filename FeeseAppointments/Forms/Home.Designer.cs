
namespace FeeseAppointments.Forms
{
	partial class Home
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.recordsBtn = new System.Windows.Forms.Button();
			this.Appointments = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// recordsBtn
			// 
			this.recordsBtn.Location = new System.Drawing.Point(184, 240);
			this.recordsBtn.Name = "recordsBtn";
			this.recordsBtn.Size = new System.Drawing.Size(125, 23);
			this.recordsBtn.TabIndex = 0;
			this.recordsBtn.Text = "Customer Records";
			this.recordsBtn.UseVisualStyleBackColor = true;
			this.recordsBtn.Click += new System.EventHandler(this.recordsBtn_Click);
			// 
			// Appointments
			// 
			this.Appointments.Location = new System.Drawing.Point(459, 240);
			this.Appointments.Name = "Appointments";
			this.Appointments.Size = new System.Drawing.Size(125, 23);
			this.Appointments.TabIndex = 1;
			this.Appointments.Text = "Appointments";
			this.Appointments.UseVisualStyleBackColor = true;
			this.Appointments.Click += new System.EventHandler(this.Appointments_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Appointments);
			this.Controls.Add(this.recordsBtn);
			this.Name = "Home";
			this.Text = "Home";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button recordsBtn;
		private System.Windows.Forms.Button Appointments;
	}
}