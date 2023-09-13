
namespace FeeseAppointments.Forms.Records
{
    partial class CustomerForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.address2Text = new System.Windows.Forms.TextBox();
            this.address2Lbl = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.zipText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(87, 360);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Add";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(209, 360);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(139, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(82, 13);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Customer Name";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(156, 59);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(45, 13);
            this.addressLbl.TabIndex = 3;
            this.addressLbl.Text = "Address";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(139, 285);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(78, 13);
            this.phoneLbl.TabIndex = 4;
            this.phoneLbl.Text = "Phone Number";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(73, 25);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(211, 20);
            this.nameInput.TabIndex = 5;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(73, 75);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(211, 20);
            this.addressInput.TabIndex = 6;
            this.addressInput.TextChanged += new System.EventHandler(this.addressInput_TextChanged);
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(73, 311);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(211, 20);
            this.phoneInput.TabIndex = 7;
            this.phoneInput.TextChanged += new System.EventHandler(this.phoneInput_TextChanged);
            // 
            // address2Text
            // 
            this.address2Text.Location = new System.Drawing.Point(73, 131);
            this.address2Text.Name = "address2Text";
            this.address2Text.Size = new System.Drawing.Size(211, 20);
            this.address2Text.TabIndex = 8;
            this.address2Text.TextChanged += new System.EventHandler(this.address2Text_TextChanged);
            // 
            // address2Lbl
            // 
            this.address2Lbl.AutoSize = true;
            this.address2Lbl.Location = new System.Drawing.Point(156, 115);
            this.address2Lbl.Name = "address2Lbl";
            this.address2Lbl.Size = new System.Drawing.Size(54, 13);
            this.address2Lbl.TabIndex = 9;
            this.address2Lbl.Text = "Address 2";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(168, 154);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(24, 13);
            this.City.TabIndex = 10;
            this.City.Text = "City";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // zipText
            // 
            this.zipText.Location = new System.Drawing.Point(73, 247);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(211, 20);
            this.zipText.TabIndex = 12;
            this.zipText.TextChanged += new System.EventHandler(this.zipText_TextChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 418);
            this.Controls.Add(this.zipText);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.address2Lbl);
            this.Controls.Add(this.address2Text);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "CustomerForm";
            this.Text = "customerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox address2Text;
        private System.Windows.Forms.Label address2Lbl;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox zipText;
    }
}