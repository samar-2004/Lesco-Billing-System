namespace BillingSystem
{
	partial class AddNewCustomer
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
			this.backbtn = new System.Windows.Forms.Button();
			this.HEADING = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPhoneNo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMeterReading = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.AddCustomerbtn = new System.Windows.Forms.Button();
			this.txtdate = new System.Windows.Forms.DateTimePicker();
			this.lbPhoneError = new System.Windows.Forms.Label();
			this.lblMeterError = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.backbtn);
			this.panel1.Controls.Add(this.HEADING);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1570, 66);
			this.panel1.TabIndex = 3;
			// 
			// backbtn
			// 
			this.backbtn.BackColor = System.Drawing.Color.DarkGreen;
			this.backbtn.BackgroundImage = global::BillingSystem.Properties.Resources.back_button;
			this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.backbtn.ForeColor = System.Drawing.Color.Crimson;
			this.backbtn.Location = new System.Drawing.Point(34, 11);
			this.backbtn.Name = "backbtn";
			this.backbtn.Size = new System.Drawing.Size(44, 42);
			this.backbtn.TabIndex = 1;
			this.backbtn.UseVisualStyleBackColor = false;
			this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
			// 
			// HEADING
			// 
			this.HEADING.AutoSize = true;
			this.HEADING.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HEADING.ForeColor = System.Drawing.Color.Black;
			this.HEADING.Location = new System.Drawing.Point(688, 8);
			this.HEADING.Name = "HEADING";
			this.HEADING.Size = new System.Drawing.Size(577, 46);
			this.HEADING.TabIndex = 0;
			this.HEADING.Text = "LESCO BILLING SYSTEM";
			this.HEADING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SlateGray;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(657, 148);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(640, 55);
			this.panel2.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(220, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "New Customer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(974, 322);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(232, 32);
			this.txtName.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.SlateGray;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Location = new System.Drawing.Point(756, 322);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(182, 31);
			this.label3.TabIndex = 10;
			this.label3.Text = "       Name       ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.SlateGray;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(754, 523);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(181, 31);
			this.label4.TabIndex = 12;
			this.label4.Text = " Date of Reg.  ";
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(974, 388);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(232, 32);
			this.txtAddress.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.SlateGray;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(756, 389);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(181, 31);
			this.label6.TabIndex = 16;
			this.label6.Text = "     Address     ";
			// 
			// txtPhoneNo
			// 
			this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhoneNo.Location = new System.Drawing.Point(974, 454);
			this.txtPhoneNo.Name = "txtPhoneNo";
			this.txtPhoneNo.Size = new System.Drawing.Size(232, 32);
			this.txtPhoneNo.TabIndex = 19;
			this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.SlateGray;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(756, 455);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(180, 31);
			this.label5.TabIndex = 18;
			this.label5.Text = "   Phone No.   ";
			// 
			// txtMeterReading
			// 
			this.txtMeterReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMeterReading.Location = new System.Drawing.Point(974, 585);
			this.txtMeterReading.Name = "txtMeterReading";
			this.txtMeterReading.Size = new System.Drawing.Size(232, 32);
			this.txtMeterReading.TabIndex = 21;
			this.txtMeterReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeterReading_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.SlateGray;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(754, 585);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(176, 28);
			this.label7.TabIndex = 20;
			this.label7.Text = " Meter Reading";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AddCustomerbtn
			// 
			this.AddCustomerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.AddCustomerbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.AddCustomerbtn.FlatAppearance.BorderSize = 2;
			this.AddCustomerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddCustomerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddCustomerbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddCustomerbtn.Location = new System.Drawing.Point(756, 709);
			this.AddCustomerbtn.Name = "AddCustomerbtn";
			this.AddCustomerbtn.Size = new System.Drawing.Size(453, 55);
			this.AddCustomerbtn.TabIndex = 22;
			this.AddCustomerbtn.Text = "Add Customer";
			this.AddCustomerbtn.UseVisualStyleBackColor = false;
			this.AddCustomerbtn.Click += new System.EventHandler(this.AddCustomerbtn_Click);
			this.AddCustomerbtn.MouseEnter += new System.EventHandler(this.AddCustomerbtn_MouseEnter);
			this.AddCustomerbtn.MouseLeave += new System.EventHandler(this.AddCustomerbtn_MouseLeave);
			// 
			// txtdate
			// 
			this.txtdate.CustomFormat = "yyyy-MM-dd";
			this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtdate.Location = new System.Drawing.Point(974, 523);
			this.txtdate.Name = "txtdate";
			this.txtdate.Size = new System.Drawing.Size(230, 26);
			this.txtdate.TabIndex = 23;
			this.txtdate.Value = new System.DateTime(2023, 11, 29, 0, 9, 3, 0);
			// 
			// lbPhoneError
			// 
			this.lbPhoneError.AutoSize = true;
			this.lbPhoneError.Location = new System.Drawing.Point(1215, 455);
			this.lbPhoneError.Name = "lbPhoneError";
			this.lbPhoneError.Size = new System.Drawing.Size(0, 20);
			this.lbPhoneError.TabIndex = 24;
			// 
			// lblMeterError
			// 
			this.lblMeterError.AutoSize = true;
			this.lblMeterError.Location = new System.Drawing.Point(1215, 592);
			this.lblMeterError.Name = "lblMeterError";
			this.lblMeterError.Size = new System.Drawing.Size(0, 20);
			this.lblMeterError.TabIndex = 25;
			// 
			// AddNewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1570, 838);
			this.Controls.Add(this.lblMeterError);
			this.Controls.Add(this.lbPhoneError);
			this.Controls.Add(this.txtdate);
			this.Controls.Add(this.AddCustomerbtn);
			this.Controls.Add(this.txtMeterReading);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPhoneNo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "AddNewCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddNewCustomer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPhoneNo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMeterReading;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button AddCustomerbtn;
		private System.Windows.Forms.DateTimePicker txtdate;
		private System.Windows.Forms.Label lbPhoneError;
		private System.Windows.Forms.Label lblMeterError;
	}
}