namespace BillingSystem
{
	partial class currentBill
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
			this.txtCurrReading = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtname = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtReferenceNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUnits = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ViewBillbtn = new System.Windows.Forms.Button();
			this.txttotalbill = new System.Windows.Forms.TextBox();
			this.txtReadingDate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDueDate = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLatePayment = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnBillCorrection = new System.Windows.Forms.Button();
			this.errorRefernceNo = new System.Windows.Forms.Label();
			this.btnViewTarrifRates = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(1738, 65);
			this.panel1.TabIndex = 2;
			// 
			// backbtn
			// 
			this.backbtn.BackColor = System.Drawing.Color.DarkGreen;
			this.backbtn.BackgroundImage = global::BillingSystem.Properties.Resources.back_button;
			this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.backbtn.ForeColor = System.Drawing.Color.Crimson;
			this.backbtn.Location = new System.Drawing.Point(40, 7);
			this.backbtn.Name = "backbtn";
			this.backbtn.Size = new System.Drawing.Size(44, 42);
			this.backbtn.TabIndex = 2;
			this.backbtn.UseVisualStyleBackColor = false;
			this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
			// 
			// HEADING
			// 
			this.HEADING.AutoSize = true;
			this.HEADING.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HEADING.ForeColor = System.Drawing.Color.Black;
			this.HEADING.Location = new System.Drawing.Point(673, 7);
			this.HEADING.Name = "HEADING";
			this.HEADING.Size = new System.Drawing.Size(577, 46);
			this.HEADING.TabIndex = 0;
			this.HEADING.Text = "LESCO BILLING SYSTEM";
			this.HEADING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCurrReading
			// 
			this.txtCurrReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCurrReading.Location = new System.Drawing.Point(1400, 522);
			this.txtCurrReading.Name = "txtCurrReading";
			this.txtCurrReading.ReadOnly = true;
			this.txtCurrReading.Size = new System.Drawing.Size(232, 32);
			this.txtCurrReading.TabIndex = 55;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.SlateGray;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Location = new System.Drawing.Point(1128, 523);
			this.label10.Margin = new System.Windows.Forms.Padding(0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(220, 31);
			this.label10.TabIndex = 54;
			this.label10.Text = " Current Reading ";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtname
			// 
			this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtname.Location = new System.Drawing.Point(1400, 411);
			this.txtname.Name = "txtname";
			this.txtname.ReadOnly = true;
			this.txtname.Size = new System.Drawing.Size(232, 32);
			this.txtname.TabIndex = 53;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.SlateGray;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label9.Location = new System.Drawing.Point(1128, 412);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(224, 31);
			this.label9.TabIndex = 52;
			this.label9.Text = "           Name         ";
			// 
			// txtReferenceNo
			// 
			this.txtReferenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferenceNo.Location = new System.Drawing.Point(488, 470);
			this.txtReferenceNo.Name = "txtReferenceNo";
			this.txtReferenceNo.Size = new System.Drawing.Size(232, 32);
			this.txtReferenceNo.TabIndex = 51;
			this.txtReferenceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReferenceNo_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.SlateGray;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(216, 470);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 31);
			this.label1.TabIndex = 50;
			this.label1.Text = " Reference No.     ";
			// 
			// txtUnits
			// 
			this.txtUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnits.Location = new System.Drawing.Point(1400, 645);
			this.txtUnits.Name = "txtUnits";
			this.txtUnits.ReadOnly = true;
			this.txtUnits.Size = new System.Drawing.Size(232, 32);
			this.txtUnits.TabIndex = 48;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.SlateGray;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(1128, 646);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(220, 31);
			this.label7.TabIndex = 47;
			this.label7.Text = " Units Consumed ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.SlateGray;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(1128, 703);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(218, 31);
			this.label4.TabIndex = 46;
			this.label4.Text = "       Total Bill       ";
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(1400, 468);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ReadOnly = true;
			this.txtAddress.Size = new System.Drawing.Size(232, 32);
			this.txtAddress.TabIndex = 57;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.SlateGray;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(1128, 469);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(223, 31);
			this.label2.TabIndex = 56;
			this.label2.Tag = " ";
			this.label2.Text = "        Address        ";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.SlateGray;
			this.panel3.Controls.Add(this.label8);
			this.panel3.Location = new System.Drawing.Point(1180, 301);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(384, 54);
			this.panel3.TabIndex = 58;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(119, 9);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.label8.Size = new System.Drawing.Size(145, 32);
			this.label8.TabIndex = 1;
			this.label8.Text = "Your Bill";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(297, 388);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(373, 26);
			this.label3.TabIndex = 59;
			this.label3.Text = "Enter Your Reference Number Below";
			// 
			// ViewBillbtn
			// 
			this.ViewBillbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ViewBillbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ViewBillbtn.FlatAppearance.BorderSize = 2;
			this.ViewBillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ViewBillbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ViewBillbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ViewBillbtn.Location = new System.Drawing.Point(216, 557);
			this.ViewBillbtn.Name = "ViewBillbtn";
			this.ViewBillbtn.Size = new System.Drawing.Size(504, 55);
			this.ViewBillbtn.TabIndex = 60;
			this.ViewBillbtn.Text = "Click to View Bill";
			this.ViewBillbtn.UseVisualStyleBackColor = false;
			this.ViewBillbtn.Click += new System.EventHandler(this.ViewBillbtn_Click);
			this.ViewBillbtn.MouseEnter += new System.EventHandler(this.ViewBillbtn_MouseEnter);
			this.ViewBillbtn.MouseLeave += new System.EventHandler(this.ViewBillbtn_MouseLeave);
			// 
			// txttotalbill
			// 
			this.txttotalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttotalbill.Location = new System.Drawing.Point(1400, 702);
			this.txttotalbill.Name = "txttotalbill";
			this.txttotalbill.ReadOnly = true;
			this.txttotalbill.Size = new System.Drawing.Size(232, 32);
			this.txttotalbill.TabIndex = 61;
			// 
			// txtReadingDate
			// 
			this.txtReadingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReadingDate.Location = new System.Drawing.Point(1400, 580);
			this.txtReadingDate.Name = "txtReadingDate";
			this.txtReadingDate.ReadOnly = true;
			this.txtReadingDate.Size = new System.Drawing.Size(232, 32);
			this.txtReadingDate.TabIndex = 63;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.SlateGray;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(1128, 581);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(223, 31);
			this.label5.TabIndex = 62;
			this.label5.Text = "    Reading  Date  ";
			// 
			// txtDueDate
			// 
			this.txtDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDueDate.Location = new System.Drawing.Point(1400, 763);
			this.txtDueDate.Name = "txtDueDate";
			this.txtDueDate.ReadOnly = true;
			this.txtDueDate.Size = new System.Drawing.Size(232, 32);
			this.txtDueDate.TabIndex = 65;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.SlateGray;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(1128, 764);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(221, 31);
			this.label6.TabIndex = 64;
			this.label6.Text = "       Due Date       ";
			// 
			// txtLatePayment
			// 
			this.txtLatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLatePayment.Location = new System.Drawing.Point(1400, 823);
			this.txtLatePayment.Name = "txtLatePayment";
			this.txtLatePayment.ReadOnly = true;
			this.txtLatePayment.Size = new System.Drawing.Size(232, 32);
			this.txtLatePayment.TabIndex = 67;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.SlateGray;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label11.Location = new System.Drawing.Point(1128, 824);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(221, 31);
			this.label11.TabIndex = 66;
			this.label11.Text = "    Late Payment   ";
			// 
			// btnBillCorrection
			// 
			this.btnBillCorrection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnBillCorrection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnBillCorrection.FlatAppearance.BorderSize = 2;
			this.btnBillCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBillCorrection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBillCorrection.Location = new System.Drawing.Point(216, 679);
			this.btnBillCorrection.Name = "btnBillCorrection";
			this.btnBillCorrection.Size = new System.Drawing.Size(504, 55);
			this.btnBillCorrection.TabIndex = 68;
			this.btnBillCorrection.Text = "Click to Apply for Bill Correction";
			this.btnBillCorrection.UseVisualStyleBackColor = false;
			this.btnBillCorrection.Click += new System.EventHandler(this.btnBillCorrection_Click);
			this.btnBillCorrection.MouseEnter += new System.EventHandler(this.btnBillCorrection_MouseEnter);
			this.btnBillCorrection.MouseLeave += new System.EventHandler(this.btnBillCorrection_MouseLeave);
			// 
			// errorRefernceNo
			// 
			this.errorRefernceNo.AutoSize = true;
			this.errorRefernceNo.Enabled = false;
			this.errorRefernceNo.ForeColor = System.Drawing.Color.Red;
			this.errorRefernceNo.Location = new System.Drawing.Point(726, 476);
			this.errorRefernceNo.Name = "errorRefernceNo";
			this.errorRefernceNo.Size = new System.Drawing.Size(212, 20);
			this.errorRefernceNo.TabIndex = 69;
			this.errorRefernceNo.Text = "* Please Enter integar values";
			// 
			// btnViewTarrifRates
			// 
			this.btnViewTarrifRates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnViewTarrifRates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnViewTarrifRates.FlatAppearance.BorderSize = 2;
			this.btnViewTarrifRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnViewTarrifRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewTarrifRates.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnViewTarrifRates.Location = new System.Drawing.Point(216, 789);
			this.btnViewTarrifRates.Name = "btnViewTarrifRates";
			this.btnViewTarrifRates.Size = new System.Drawing.Size(504, 55);
			this.btnViewTarrifRates.TabIndex = 70;
			this.btnViewTarrifRates.Text = "Click to View Tariff Rates";
			this.btnViewTarrifRates.UseVisualStyleBackColor = false;
			this.btnViewTarrifRates.Click += new System.EventHandler(this.btnViewTarrifRates_Click);
			this.btnViewTarrifRates.MouseEnter += new System.EventHandler(this.btnViewTarrifRates_MouseEnter);
			this.btnViewTarrifRates.MouseLeave += new System.EventHandler(this.btnViewTarrifRates_MouseLeave);
			// 
			// currentBill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1738, 1050);
			this.Controls.Add(this.btnViewTarrifRates);
			this.Controls.Add(this.errorRefernceNo);
			this.Controls.Add(this.btnBillCorrection);
			this.Controls.Add(this.txtLatePayment);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtDueDate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtReadingDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txttotalbill);
			this.Controls.Add(this.ViewBillbtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCurrReading);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtReferenceNo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUnits);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Name = "currentBill";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Billing";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.TextBox txtCurrReading;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtReferenceNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUnits;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ViewBillbtn;
		private System.Windows.Forms.TextBox txttotalbill;
		private System.Windows.Forms.TextBox txtReadingDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDueDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtLatePayment;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnBillCorrection;
		private System.Windows.Forms.Label errorRefernceNo;
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Button btnViewTarrifRates;
	}
}