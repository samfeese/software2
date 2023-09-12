
namespace FeeseAppointments.Forms.Records
{
	partial class Records
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Home = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(698, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(59, 415);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Enabled = false;
            this.addCustomer.Location = new System.Drawing.Point(482, 415);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(75, 23);
            this.addCustomer.TabIndex = 2;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Enabled = false;
            this.deleteCustomer.Location = new System.Drawing.Point(673, 415);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.deleteCustomer.TabIndex = 3;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Enabled = false;
            this.updateCustomer.Location = new System.Drawing.Point(574, 415);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(75, 23);
            this.updateCustomer.TabIndex = 4;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Records";
            this.Text = "Records";
            this.Load += new System.EventHandler(this.Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button updateCustomer;
    }
}