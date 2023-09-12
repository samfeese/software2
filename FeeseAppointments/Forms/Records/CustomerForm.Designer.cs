
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
            this.nameLbl.Location = new System.Drawing.Point(143, 74);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(82, 13);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Customer Name";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(154, 164);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(45, 13);
            this.addressLbl.TabIndex = 3;
            this.addressLbl.Text = "Address";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(143, 250);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(78, 13);
            this.phoneLbl.TabIndex = 4;
            this.phoneLbl.Text = "Phone Number";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(73, 90);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(211, 20);
            this.nameInput.TabIndex = 5;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(73, 180);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(211, 20);
            this.addressInput.TabIndex = 6;
            this.addressInput.TextChanged += new System.EventHandler(this.addressInput_TextChanged);
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(73, 266);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(211, 20);
            this.phoneInput.TabIndex = 7;
            this.phoneInput.TextChanged += new System.EventHandler(this.phoneInput_TextChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 418);
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
    }
}