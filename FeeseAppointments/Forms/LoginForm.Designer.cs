
namespace FeeseAppointments.Forms
{
	partial class LoginForm
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
			this.passwordInput = new System.Windows.Forms.TextBox();
			this.usernameInput = new System.Windows.Forms.TextBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// passwordInput
			// 
			this.passwordInput.Location = new System.Drawing.Point(343, 249);
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.Size = new System.Drawing.Size(100, 20);
			this.passwordInput.TabIndex = 0;
			this.passwordInput.TextChanged += new System.EventHandler(this.passwordInput_TextChanged);
			// 
			// usernameInput
			// 
			this.usernameInput.Location = new System.Drawing.Point(343, 116);
			this.usernameInput.Name = "usernameInput";
			this.usernameInput.Size = new System.Drawing.Size(100, 20);
			this.usernameInput.TabIndex = 1;
			this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(355, 310);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(75, 23);
			this.loginBtn.TabIndex = 2;
			this.loginBtn.Text = "login";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.Location = new System.Drawing.Point(366, 100);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
			this.UsernameLabel.TabIndex = 3;
			this.UsernameLabel.Text = "Username";
			this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(366, 233);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(53, 13);
			this.passwordLabel.TabIndex = 4;
			this.passwordLabel.Text = "Password";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.usernameInput);
			this.Controls.Add(this.passwordInput);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox passwordInput;
		private System.Windows.Forms.TextBox usernameInput;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label passwordLabel;
	}
}