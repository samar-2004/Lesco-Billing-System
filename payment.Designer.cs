namespace BillingSystem
{
	partial class payment
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.HEADING = new System.Windows.Forms.Label();
			this.backbtn = new System.Windows.Forms.Button();
			this.gridviewMonthlyReading = new System.Windows.Forms.DataGridView();
			this.lblerror = new System.Windows.Forms.Label();
			this.AddPaymntbtn = new System.Windows.Forms.Button();
			this.txtBillAmount = new System.Windows.Forms.TextBox();
			this.dcd = new System.Windows.Forms.Label();
			this.txtReadingId = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtReferenceNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtpaymentdate = new System.Windows.Forms.DateTimePicker();
			this.txtUnitsConsumed = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPayment = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDuedate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtReadingDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridviewMonthlyReading)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1817, 66);
			this.panel1.TabIndex = 4;
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
			// gridviewMonthlyReading
			// 
			this.gridviewMonthlyReading.AllowUserToAddRows = false;
			this.gridviewMonthlyReading.AllowUserToDeleteRows = false;
			this.gridviewMonthlyReading.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SlateGray;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridviewMonthlyReading.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.gridviewMonthlyReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridviewMonthlyReading.DefaultCellStyle = dataGridViewCellStyle12;
			this.gridviewMonthlyReading.GridColor = System.Drawing.Color.Black;
			this.gridviewMonthlyReading.Location = new System.Drawing.Point(238, 306);
			this.gridviewMonthlyReading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gridviewMonthlyReading.Name = "gridviewMonthlyReading";
			this.gridviewMonthlyReading.ReadOnly = true;
			this.gridviewMonthlyReading.RowHeadersWidth = 20;
			this.gridviewMonthlyReading.Size = new System.Drawing.Size(730, 477);
			this.gridviewMonthlyReading.TabIndex = 41;
			this.gridviewMonthlyReading.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewMonthlyReading_CellClick);
			// 
			// lblerror
			// 
			this.lblerror.AutoSize = true;
			this.lblerror.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblerror.ForeColor = System.Drawing.Color.Red;
			this.lblerror.Location = new System.Drawing.Point(1445, 611);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new System.Drawing.Size(0, 20);
			this.lblerror.TabIndex = 62;
			// 
			// AddPaymntbtn
			// 
			this.AddPaymntbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.AddPaymntbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.AddPaymntbtn.FlatAppearance.BorderSize = 2;
			this.AddPaymntbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddPaymntbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddPaymntbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddPaymntbtn.Location = new System.Drawing.Point(1102, 823);
			this.AddPaymntbtn.Name = "AddPaymntbtn";
			this.AddPaymntbtn.Size = new System.Drawing.Size(502, 55);
			this.AddPaymntbtn.TabIndex = 61;
			this.AddPaymntbtn.Text = "Click to Add Payment";
			this.AddPaymntbtn.UseVisualStyleBackColor = false;
			this.AddPaymntbtn.Click += new System.EventHandler(this.AddPaymntbtn_Click);
			this.AddPaymntbtn.MouseEnter += new System.EventHandler(this.updateReadingbtn_MouseEnter);
			this.AddPaymntbtn.MouseLeave += new System.EventHandler(this.AddPaymntbtn_MouseLeave);
			// 
			// txtBillAmount
			// 
			this.txtBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBillAmount.Location = new System.Drawing.Point(1373, 514);
			this.txtBillAmount.Name = "txtBillAmount";
			this.txtBillAmount.ReadOnly = true;
			this.txtBillAmount.Size = new System.Drawing.Size(232, 32);
			this.txtBillAmount.TabIndex = 60;
			// 
			// dcd
			// 
			this.dcd.AutoSize = true;
			this.dcd.BackColor = System.Drawing.Color.SlateGray;
			this.dcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dcd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dcd.Location = new System.Drawing.Point(1101, 515);
			this.dcd.Margin = new System.Windows.Forms.Padding(0);
			this.dcd.Name = "dcd";
			this.dcd.Size = new System.Drawing.Size(224, 31);
			this.dcd.TabIndex = 59;
			this.dcd.Text = "     Bill  Amount     ";
			this.dcd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtReadingId
			// 
			this.txtReadingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReadingId.Location = new System.Drawing.Point(1374, 253);
			this.txtReadingId.Name = "txtReadingId";
			this.txtReadingId.ReadOnly = true;
			this.txtReadingId.Size = new System.Drawing.Size(232, 32);
			this.txtReadingId.TabIndex = 58;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.SlateGray;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label9.Location = new System.Drawing.Point(1102, 254);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(226, 31);
			this.label9.TabIndex = 57;
			this.label9.Text = "Meter Reading ID ";
			// 
			// txtReferenceNo
			// 
			this.txtReferenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferenceNo.Location = new System.Drawing.Point(1373, 317);
			this.txtReferenceNo.Name = "txtReferenceNo";
			this.txtReferenceNo.ReadOnly = true;
			this.txtReferenceNo.Size = new System.Drawing.Size(232, 32);
			this.txtReferenceNo.TabIndex = 56;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.SlateGray;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(1101, 317);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 31);
			this.label1.TabIndex = 55;
			this.label1.Text = " Reference No.     ";
			// 
			// txtpaymentdate
			// 
			this.txtpaymentdate.CustomFormat = "yyyy-MM-dd";
			this.txtpaymentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtpaymentdate.Location = new System.Drawing.Point(1371, 658);
			this.txtpaymentdate.Name = "txtpaymentdate";
			this.txtpaymentdate.Size = new System.Drawing.Size(230, 26);
			this.txtpaymentdate.TabIndex = 54;
			this.txtpaymentdate.Value = new System.DateTime(2023, 11, 29, 0, 9, 3, 0);
			this.txtpaymentdate.ValueChanged += new System.EventHandler(this.txtpaymentdate_ValueChanged);
			// 
			// txtUnitsConsumed
			// 
			this.txtUnitsConsumed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnitsConsumed.Location = new System.Drawing.Point(1371, 382);
			this.txtUnitsConsumed.Name = "txtUnitsConsumed";
			this.txtUnitsConsumed.ReadOnly = true;
			this.txtUnitsConsumed.Size = new System.Drawing.Size(232, 32);
			this.txtUnitsConsumed.TabIndex = 53;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.SlateGray;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(1099, 383);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(227, 31);
			this.label7.TabIndex = 52;
			this.label7.Text = " Units Consumed  ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.SlateGray;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(1099, 653);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(226, 31);
			this.label4.TabIndex = 51;
			this.label4.Text = "  Date of Payment ";
			// 
			// txtPayment
			// 
			this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPayment.Location = new System.Drawing.Point(1374, 725);
			this.txtPayment.Name = "txtPayment";
			this.txtPayment.Size = new System.Drawing.Size(232, 32);
			this.txtPayment.TabIndex = 65;
			this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayment_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.SlateGray;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(1102, 726);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(225, 31);
			this.label3.TabIndex = 64;
			this.label3.Text = "     Paid Amount    ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtDuedate
			// 
			this.txtDuedate.CustomFormat = "yyyy-MM-dd";
			this.txtDuedate.Enabled = false;
			this.txtDuedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtDuedate.Location = new System.Drawing.Point(1374, 586);
			this.txtDuedate.Name = "txtDuedate";
			this.txtDuedate.Size = new System.Drawing.Size(230, 26);
			this.txtDuedate.TabIndex = 68;
			this.txtDuedate.Value = new System.DateTime(2023, 11, 29, 0, 9, 3, 0);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.SlateGray;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(1102, 581);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(221, 31);
			this.label5.TabIndex = 67;
			this.label5.Text = "      Due  Date       ";
			// 
			// txtReadingDate
			// 
			this.txtReadingDate.CustomFormat = "yyyy-MM-dd";
			this.txtReadingDate.Enabled = false;
			this.txtReadingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtReadingDate.Location = new System.Drawing.Point(1374, 451);
			this.txtReadingDate.Name = "txtReadingDate";
			this.txtReadingDate.Size = new System.Drawing.Size(230, 26);
			this.txtReadingDate.TabIndex = 71;
			this.txtReadingDate.Value = new System.DateTime(2023, 11, 29, 0, 9, 3, 0);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.SlateGray;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(1102, 446);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(223, 31);
			this.label6.TabIndex = 70;
			this.label6.Text = "   Reading Date    ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(1445, 476);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 20);
			this.label8.TabIndex = 69;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(332, 254);
			this.label10.Name = "label10";
			this.label10.Padding = new System.Windows.Forms.Padding(5);
			this.label10.Size = new System.Drawing.Size(533, 35);
			this.label10.TabIndex = 72;
			this.label10.Text = "Select A Monthly Record Whose payment You want to Add";
			// 
			// payment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1817, 1050);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtReadingDate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtDuedate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPayment);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblerror);
			this.Controls.Add(this.AddPaymntbtn);
			this.Controls.Add(this.txtBillAmount);
			this.Controls.Add(this.dcd);
			this.Controls.Add(this.txtReadingId);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtReferenceNo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtpaymentdate);
			this.Controls.Add(this.txtUnitsConsumed);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.gridviewMonthlyReading);
			this.Controls.Add(this.panel1);
			this.Name = "payment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.payment_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridviewMonthlyReading)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.DataGridView gridviewMonthlyReading;
		private System.Windows.Forms.Label lblerror;
		private System.Windows.Forms.Button AddPaymntbtn;
		private System.Windows.Forms.TextBox txtBillAmount;
		private System.Windows.Forms.Label dcd;
		private System.Windows.Forms.TextBox txtReadingId;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtReferenceNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker txtpaymentdate;
		private System.Windows.Forms.TextBox txtUnitsConsumed;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPayment;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker txtDuedate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker txtReadingDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
	}
}