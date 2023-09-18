
namespace FeeseAppointments.Forms.Appointment
{
    partial class AppointmentInput
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
            this.typeInput = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.typeLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerLbl = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.addApptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeInput
            // 
            this.typeInput.Location = new System.Drawing.Point(326, 66);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(202, 20);
            this.typeInput.TabIndex = 1;
            this.typeInput.TextChanged += new System.EventHandler(this.typeInput_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(323, 50);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(31, 13);
            this.typeLbl.TabIndex = 5;
            this.typeLbl.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(326, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // customerLbl
            // 
            this.customerLbl.AutoSize = true;
            this.customerLbl.Location = new System.Drawing.Point(326, 110);
            this.customerLbl.Name = "customerLbl";
            this.customerLbl.Size = new System.Drawing.Size(51, 13);
            this.customerLbl.TabIndex = 7;
            this.customerLbl.Text = "Customer";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(57, 52);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // addApptBtn
            // 
            this.addApptBtn.Location = new System.Drawing.Point(409, 244);
            this.addApptBtn.Name = "addApptBtn";
            this.addApptBtn.Size = new System.Drawing.Size(75, 23);
            this.addApptBtn.TabIndex = 8;
            this.addApptBtn.Text = "Add";
            this.addApptBtn.UseVisualStyleBackColor = true;
            this.addApptBtn.Click += new System.EventHandler(this.addApptBtn_Click);
            // 
            // AppointmentInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 351);
            this.Controls.Add(this.addApptBtn);
            this.Controls.Add(this.customerLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.typeInput);
            this.Name = "AppointmentInput";
            this.Text = "AppointmentInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox typeInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label customerLbl;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button addApptBtn;
    }
}