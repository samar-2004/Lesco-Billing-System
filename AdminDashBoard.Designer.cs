namespace BillingSystem
{
	partial class AdminDashBoard
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
			this.HEADING = new System.Windows.Forms.Label();
			this.billPaymentbtn = new System.Windows.Forms.Button();
			this.CorrectionRequestsBtn = new System.Windows.Forms.Button();
			this.UpdateReadingBTN = new System.Windows.Forms.Button();
			this.addnewCustomerbtn = new System.Windows.Forms.Button();
			this.viewRecordsbtn = new System.Windows.Forms.Button();
			this.backbtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(1633, 66);
			this.panel1.TabIndex = 2;
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
			// billPaymentbtn
			// 
			this.billPaymentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.billPaymentbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.billPaymentbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.billPaymentbtn.FlatAppearance.BorderSize = 2;
			this.billPaymentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.billPaymentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.billPaymentbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.billPaymentbtn.Image = global::BillingSystem.Properties.Resources.back_payment_icon_10__1_;
			this.billPaymentbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.billPaymentbtn.Location = new System.Drawing.Point(628, 541);
			this.billPaymentbtn.Name = "billPaymentbtn";
			this.billPaymentbtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.billPaymentbtn.Size = new System.Drawing.Size(724, 102);
			this.billPaymentbtn.TabIndex = 8;
			this.billPaymentbtn.Text = "Bill  Payment";
			this.billPaymentbtn.UseVisualStyleBackColor = false;
			this.billPaymentbtn.Click += new System.EventHandler(this.billPaymentbtn_Click);
			this.billPaymentbtn.MouseEnter += new System.EventHandler(this.billPaymentbtn_MouseEnter);
			this.billPaymentbtn.MouseLeave += new System.EventHandler(this.billPaymentbtn_MouseLeave);
			// 
			// CorrectionRequestsBtn
			// 
			this.CorrectionRequestsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CorrectionRequestsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.CorrectionRequestsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.CorrectionRequestsBtn.FlatAppearance.BorderSize = 2;
			this.CorrectionRequestsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CorrectionRequestsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CorrectionRequestsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CorrectionRequestsBtn.Image = global::BillingSystem.Properties.Resources.correctionnew_fotor_bg_remover_20231203164736__1_;
			this.CorrectionRequestsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.CorrectionRequestsBtn.Location = new System.Drawing.Point(1074, 422);
			this.CorrectionRequestsBtn.Name = "CorrectionRequestsBtn";
			this.CorrectionRequestsBtn.Size = new System.Drawing.Size(278, 102);
			this.CorrectionRequestsBtn.TabIndex = 7;
			this.CorrectionRequestsBtn.Text = "     Bill Corrections";
			this.CorrectionRequestsBtn.UseVisualStyleBackColor = false;
			this.CorrectionRequestsBtn.Click += new System.EventHandler(this.CorrectionRequestsBtn_Click);
			this.CorrectionRequestsBtn.MouseEnter += new System.EventHandler(this.CorrectionRequestsBtn_MouseEnter);
			this.CorrectionRequestsBtn.MouseLeave += new System.EventHandler(this.CorrectionRequestsBtn_MouseLeave);
			// 
			// UpdateReadingBTN
			// 
			this.UpdateReadingBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.UpdateReadingBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.UpdateReadingBTN.FlatAppearance.BorderSize = 2;
			this.UpdateReadingBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UpdateReadingBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateReadingBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.UpdateReadingBTN.Image = global::BillingSystem.Properties.Resources.update__1_;
			this.UpdateReadingBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UpdateReadingBTN.Location = new System.Drawing.Point(628, 422);
			this.UpdateReadingBTN.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
			this.UpdateReadingBTN.Name = "UpdateReadingBTN";
			this.UpdateReadingBTN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.UpdateReadingBTN.Size = new System.Drawing.Size(440, 102);
			this.UpdateReadingBTN.TabIndex = 6;
			this.UpdateReadingBTN.Text = "Update Meter Readings";
			this.UpdateReadingBTN.UseVisualStyleBackColor = false;
			this.UpdateReadingBTN.Click += new System.EventHandler(this.UpdateReadingBTN_Click);
			this.UpdateReadingBTN.MouseEnter += new System.EventHandler(this.UpdateReadingBTN_MouseEnter);
			this.UpdateReadingBTN.MouseLeave += new System.EventHandler(this.UpdateReadingBTN_MouseLeave);
			// 
			// addnewCustomerbtn
			// 
			this.addnewCustomerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.addnewCustomerbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.addnewCustomerbtn.FlatAppearance.BorderSize = 2;
			this.addnewCustomerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addnewCustomerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addnewCustomerbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.addnewCustomerbtn.Image = global::BillingSystem.Properties.Resources.add_customer__1_;
			this.addnewCustomerbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addnewCustomerbtn.Location = new System.Drawing.Point(912, 297);
			this.addnewCustomerbtn.Name = "addnewCustomerbtn";
			this.addnewCustomerbtn.Size = new System.Drawing.Size(440, 102);
			this.addnewCustomerbtn.TabIndex = 4;
			this.addnewCustomerbtn.Text = "Add New Customer";
			this.addnewCustomerbtn.UseVisualStyleBackColor = false;
			this.addnewCustomerbtn.Click += new System.EventHandler(this.addnewCustomerbtn_Click);
			this.addnewCustomerbtn.MouseEnter += new System.EventHandler(this.addnewCustomerbtn_MouseEnter);
			this.addnewCustomerbtn.MouseLeave += new System.EventHandler(this.addnewCustomerbtn_MouseLeave);
			// 
			// viewRecordsbtn
			// 
			this.viewRecordsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.viewRecordsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.viewRecordsbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.viewRecordsbtn.FlatAppearance.BorderSize = 2;
			this.viewRecordsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.viewRecordsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewRecordsbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.viewRecordsbtn.Image = global::BillingSystem.Properties.Resources.table__2___1_;
			this.viewRecordsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.viewRecordsbtn.Location = new System.Drawing.Point(628, 297);
			this.viewRecordsbtn.Name = "viewRecordsbtn";
			this.viewRecordsbtn.Size = new System.Drawing.Size(278, 102);
			this.viewRecordsbtn.TabIndex = 5;
			this.viewRecordsbtn.Text = "View Records";
			this.viewRecordsbtn.UseVisualStyleBackColor = false;
			this.viewRecordsbtn.Click += new System.EventHandler(this.viewRecordsbtn_Click);
			this.viewRecordsbtn.MouseEnter += new System.EventHandler(this.viewRecordsbtn_MouseEnter);
			this.viewRecordsbtn.MouseLeave += new System.EventHandler(this.viewRecordsbtn_MouseLeave);
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
			// AdminDashBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1633, 918);
			this.Controls.Add(this.billPaymentbtn);
			this.Controls.Add(this.CorrectionRequestsBtn);
			this.Controls.Add(this.UpdateReadingBTN);
			this.Controls.Add(this.addnewCustomerbtn);
			this.Controls.Add(this.viewRecordsbtn);
			this.Controls.Add(this.panel1);
			this.Name = "AdminDashBoard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminDashBoard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.Button viewRecordsbtn;
		private System.Windows.Forms.Button addnewCustomerbtn;
		private System.Windows.Forms.Button UpdateReadingBTN;
		private System.Windows.Forms.Button CorrectionRequestsBtn;
		private System.Windows.Forms.Button billPaymentbtn;
	}
}