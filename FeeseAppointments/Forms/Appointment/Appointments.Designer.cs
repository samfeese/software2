
namespace FeeseAppointments.Forms.Appointment
{
    partial class Appointments
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
            this.appointmentData = new System.Windows.Forms.DataGridView();
            this.addApptBtn = new System.Windows.Forms.Button();
            this.updateApptBtn = new System.Windows.Forms.Button();
            this.deleteApptBtn = new System.Windows.Forms.Button();
            this.allViewRadio = new System.Windows.Forms.RadioButton();
            this.monthViewRadio = new System.Windows.Forms.RadioButton();
            this.weekViewRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.homeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentData
            // 
            this.appointmentData.AllowUserToAddRows = false;
            this.appointmentData.AllowUserToDeleteRows = false;
            this.appointmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentData.Location = new System.Drawing.Point(46, 12);
            this.appointmentData.Name = "appointmentData";
            this.appointmentData.ReadOnly = true;
            this.appointmentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentData.Size = new System.Drawing.Size(708, 331);
            this.appointmentData.TabIndex = 0;
            this.appointmentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentData_CellClick);
            // 
            // addApptBtn
            // 
            this.addApptBtn.Location = new System.Drawing.Point(512, 426);
            this.addApptBtn.Name = "addApptBtn";
            this.addApptBtn.Size = new System.Drawing.Size(75, 23);
            this.addApptBtn.TabIndex = 1;
            this.addApptBtn.Text = "Add";
            this.addApptBtn.UseVisualStyleBackColor = true;
            this.addApptBtn.Click += new System.EventHandler(this.addApptBtn_Click);
            // 
            // updateApptBtn
            // 
            this.updateApptBtn.Location = new System.Drawing.Point(593, 426);
            this.updateApptBtn.Name = "updateApptBtn";
            this.updateApptBtn.Size = new System.Drawing.Size(75, 23);
            this.updateApptBtn.TabIndex = 2;
            this.updateApptBtn.Text = "Update";
            this.updateApptBtn.UseVisualStyleBackColor = true;
            this.updateApptBtn.Click += new System.EventHandler(this.updateApptBtn_Click);
            // 
            // deleteApptBtn
            // 
            this.deleteApptBtn.Location = new System.Drawing.Point(674, 426);
            this.deleteApptBtn.Name = "deleteApptBtn";
            this.deleteApptBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteApptBtn.TabIndex = 3;
            this.deleteApptBtn.Text = "Delete";
            this.deleteApptBtn.UseVisualStyleBackColor = true;
            this.deleteApptBtn.Click += new System.EventHandler(this.deleteApptBtn_Click);
            // 
            // allViewRadio
            // 
            this.allViewRadio.AutoSize = true;
            this.allViewRadio.Location = new System.Drawing.Point(6, 19);
            this.allViewRadio.Name = "allViewRadio";
            this.allViewRadio.Size = new System.Drawing.Size(36, 17);
            this.allViewRadio.TabIndex = 4;
            this.allViewRadio.TabStop = true;
            this.allViewRadio.Text = "All";
            this.allViewRadio.UseVisualStyleBackColor = true;
            this.allViewRadio.CheckedChanged += new System.EventHandler(this.allViewRadio_CheckedChanged);
            // 
            // monthViewRadio
            // 
            this.monthViewRadio.AutoSize = true;
            this.monthViewRadio.Location = new System.Drawing.Point(6, 42);
            this.monthViewRadio.Name = "monthViewRadio";
            this.monthViewRadio.Size = new System.Drawing.Size(55, 17);
            this.monthViewRadio.TabIndex = 5;
            this.monthViewRadio.TabStop = true;
            this.monthViewRadio.Text = "Month";
            this.monthViewRadio.UseVisualStyleBackColor = true;
            this.monthViewRadio.CheckedChanged += new System.EventHandler(this.monthViewRadio_CheckedChanged);
            // 
            // weekViewRadio
            // 
            this.weekViewRadio.AutoSize = true;
            this.weekViewRadio.Location = new System.Drawing.Point(6, 67);
            this.weekViewRadio.Name = "weekViewRadio";
            this.weekViewRadio.Size = new System.Drawing.Size(54, 17);
            this.weekViewRadio.TabIndex = 6;
            this.weekViewRadio.TabStop = true;
            this.weekViewRadio.Text = "Week";
            this.weekViewRadio.UseVisualStyleBackColor = true;
            this.weekViewRadio.CheckedChanged += new System.EventHandler(this.weekViewRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allViewRadio);
            this.groupBox1.Controls.Add(this.monthViewRadio);
            this.groupBox1.Controls.Add(this.weekViewRadio);
            this.groupBox1.Location = new System.Drawing.Point(46, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 93);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select View";
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(184, 425);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 23);
            this.homeBtn.TabIndex = 9;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.Home_Click);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteApptBtn);
            this.Controls.Add(this.updateApptBtn);
            this.Controls.Add(this.addApptBtn);
            this.Controls.Add(this.appointmentData);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentData;
        private System.Windows.Forms.Button addApptBtn;
        private System.Windows.Forms.Button updateApptBtn;
        private System.Windows.Forms.Button deleteApptBtn;
        private System.Windows.Forms.RadioButton allViewRadio;
        private System.Windows.Forms.RadioButton monthViewRadio;
        private System.Windows.Forms.RadioButton weekViewRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button homeBtn;
    }
}