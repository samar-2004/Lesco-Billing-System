namespace BillingSystem
{
	partial class AdminLogIn
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.HEADING = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.txtusername = new System.Windows.Forms.TextBox();
			this.txtpassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.usernameError = new System.Windows.Forms.Label();
			this.passwordErro = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.HEADING);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1727, 65);
			this.panel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkGreen;
			this.button1.BackgroundImage = global::BillingSystem.Properties.Resources.back_button;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.ForeColor = System.Drawing.Color.Crimson;
			this.button1.Location = new System.Drawing.Point(34, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(43, 42);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// HEADING
			// 
			this.HEADING.AutoSize = true;
			this.HEADING.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HEADING.ForeColor = System.Drawing.Color.Black;
			this.HEADING.Location = new System.Drawing.Point(688, 7);
			this.HEADING.Name = "HEADING";
			this.HEADING.Size = new System.Drawing.Size(577, 46);
			this.HEADING.TabIndex = 0;
			this.HEADING.Text = "LESCO BILLING SYSTEM";
			this.HEADING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel3.Location = new System.Drawing.Point(279, 713);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(900, 4);
			this.panel3.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Location = new System.Drawing.Point(400, 202);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(4, 631);
			this.panel2.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(770, 251);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 31);
			this.label2.TabIndex = 7;
			this.label2.Text = "User Name ";
			// 
			// txtusername
			// 
			this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtusername.Location = new System.Drawing.Point(963, 247);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(232, 35);
			this.txtusername.TabIndex = 8;
			// 
			// txtpassword
			// 
			this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpassword.Location = new System.Drawing.Point(963, 340);
			this.txtpassword.Name = "txtpassword";
			this.txtpassword.PasswordChar = '*';
			this.txtpassword.Size = new System.Drawing.Size(232, 35);
			this.txtpassword.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(770, 344);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 31);
			this.label3.TabIndex = 9;
			this.label3.Text = "Password   ";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(770, 447);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(425, 53);
			this.button2.TabIndex = 11;
			this.button2.Text = "Log In";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
			this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
			// 
			// usernameError
			// 
			this.usernameError.AutoSize = true;
			this.usernameError.Enabled = false;
			this.usernameError.ForeColor = System.Drawing.Color.Red;
			this.usernameError.Location = new System.Drawing.Point(1201, 257);
			this.usernameError.Name = "usernameError";
			this.usernameError.Size = new System.Drawing.Size(150, 20);
			this.usernameError.TabIndex = 12;
			this.usernameError.Text = "* Invalid  User name";
			// 
			// passwordErro
			// 
			this.passwordErro.AutoSize = true;
			this.passwordErro.Enabled = false;
			this.passwordErro.ForeColor = System.Drawing.Color.Red;
			this.passwordErro.Location = new System.Drawing.Point(1201, 350);
			this.passwordErro.Name = "passwordErro";
			this.passwordErro.Size = new System.Drawing.Size(141, 20);
			this.passwordErro.TabIndex = 13;
			this.passwordErro.Text = "* Invalid  Password";
			// 
			// AdminLogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1727, 894);
			this.Controls.Add(this.passwordErro);
			this.Controls.Add(this.usernameError);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtpassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtusername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "AdminLogIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Log In";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtusername;
		private System.Windows.Forms.TextBox txtpassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label usernameError;
		private System.Windows.Forms.Label passwordErro;
	}
}