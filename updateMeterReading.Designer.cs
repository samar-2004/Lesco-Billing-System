namespace BillingSystem
{
	partial class updateMeterReading
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.backbtn = new System.Windows.Forms.Button();
			this.HEADING = new System.Windows.Forms.Label();
			this.txtdate = new System.Windows.Forms.DateTimePicker();
			this.txtPrevReading = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtReferenceNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.customerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lescoDataSet = new BillingSystem.lescoDataSet();
			this.customerTBLTableAdapter = new BillingSystem.lescoDataSetTableAdapters.CustomerTBLTableAdapter();
			this.CustomerGridView = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.gridviewMeterReading = new System.Windows.Forms.DataGridView();
			this.txtReadingId = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCurrReading = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.updateReadingbtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lescoDataSet1 = new BillingSystem.lescoDataSet();
			this.labeleror = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerTBLBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lescoDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridviewMeterReading)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lescoDataSet1)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1786, 66);
			this.panel1.TabIndex = 4;
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
			// txtdate
			// 
			this.txtdate.CustomFormat = "yyyy-MM-dd";
			this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtdate.Location = new System.Drawing.Point(938, 500);
			this.txtdate.Name = "txtdate";
			this.txtdate.Size = new System.Drawing.Size(230, 26);
			this.txtdate.TabIndex = 34;
			this.txtdate.Value = new System.DateTime(2023, 11, 29, 0, 9, 3, 0);
			this.txtdate.ValueChanged += new System.EventHandler(this.txtdate_ValueChanged);
			// 
			// txtPrevReading
			// 
			this.txtPrevReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrevReading.Location = new System.Drawing.Point(938, 356);
			this.txtPrevReading.Name = "txtPrevReading";
			this.txtPrevReading.ReadOnly = true;
			this.txtPrevReading.Size = new System.Drawing.Size(232, 32);
			this.txtPrevReading.TabIndex = 33;
			this.txtPrevReading.TextChanged += new System.EventHandler(this.txtPrevReading_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.SlateGray;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(666, 357);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(229, 31);
			this.label7.TabIndex = 32;
			this.label7.Text = "Previous Reading ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.SlateGray;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(666, 495);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(231, 31);
			this.label4.TabIndex = 27;
			this.label4.Text = "  Date of Reading  ";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// txtReferenceNo
			// 
			this.txtReferenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferenceNo.Location = new System.Drawing.Point(938, 284);
			this.txtReferenceNo.Name = "txtReferenceNo";
			this.txtReferenceNo.ReadOnly = true;
			this.txtReferenceNo.Size = new System.Drawing.Size(232, 32);
			this.txtReferenceNo.TabIndex = 37;
			this.txtReferenceNo.TextChanged += new System.EventHandler(this.txtReferenceNo_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.SlateGray;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(666, 284);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 31);
			this.label1.TabIndex = 36;
			this.label1.Text = " Reference No.     ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// customerTBLBindingSource
			// 
			this.customerTBLBindingSource.DataMember = "CustomerTBL";
			this.customerTBLBindingSource.DataSource = this.lescoDataSet;
			// 
			// lescoDataSet
			// 
			this.lescoDataSet.DataSetName = "lescoDataSet";
			this.lescoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// customerTBLTableAdapter
			// 
			this.customerTBLTableAdapter.ClearBeforeFill = true;
			// 
			// CustomerGridView
			// 
			this.CustomerGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.CustomerGridView.AllowUserToAddRows = false;
			this.CustomerGridView.AllowUserToDeleteRows = false;
			this.CustomerGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.CustomerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.CustomerGridView.DefaultCellStyle = dataGridViewCellStyle6;
			this.CustomerGridView.GridColor = System.Drawing.Color.Black;
			this.CustomerGridView.Location = new System.Drawing.Point(70, 268);
			this.CustomerGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CustomerGridView.Name = "CustomerGridView";
			this.CustomerGridView.ReadOnly = true;
			this.CustomerGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.CustomerGridView.RowHeadersVisible = false;
			this.CustomerGridView.RowHeadersWidth = 62;
			this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CustomerGridView.Size = new System.Drawing.Size(384, 304);
			this.CustomerGridView.TabIndex = 38;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SlateGray;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(70, 208);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(384, 38);
			this.panel2.TabIndex = 39;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(79, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer Details";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.SlateGray;
			this.panel3.Controls.Add(this.label8);
			this.panel3.Location = new System.Drawing.Point(1343, 208);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(384, 38);
			this.panel3.TabIndex = 41;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(103, 2);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(184, 29);
			this.label8.TabIndex = 1;
			this.label8.Text = "Meter Readings";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gridviewMeterReading
			// 
			this.gridviewMeterReading.AllowUserToAddRows = false;
			this.gridviewMeterReading.AllowUserToDeleteRows = false;
			this.gridviewMeterReading.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateGray;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridviewMeterReading.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.gridviewMeterReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridviewMeterReading.DefaultCellStyle = dataGridViewCellStyle8;
			this.gridviewMeterReading.GridColor = System.Drawing.Color.Black;
			this.gridviewMeterReading.Location = new System.Drawing.Point(1343, 268);
			this.gridviewMeterReading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gridviewMeterReading.Name = "gridviewMeterReading";
			this.gridviewMeterReading.ReadOnly = true;
			this.gridviewMeterReading.RowHeadersWidth = 20;
			this.gridviewMeterReading.Size = new System.Drawing.Size(384, 304);
			this.gridviewMeterReading.TabIndex = 40;
			this.gridviewMeterReading.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewMeterReading_CellClick);
			// 
			// txtReadingId
			// 
			this.txtReadingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReadingId.Location = new System.Drawing.Point(938, 207);
			this.txtReadingId.Name = "txtReadingId";
			this.txtReadingId.ReadOnly = true;
			this.txtReadingId.Size = new System.Drawing.Size(232, 32);
			this.txtReadingId.TabIndex = 43;
			this.txtReadingId.TextChanged += new System.EventHandler(this.txtReadingId_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.SlateGray;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label9.Location = new System.Drawing.Point(666, 208);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(226, 31);
			this.label9.TabIndex = 42;
			this.label9.Text = "Meter Reading ID ";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// txtCurrReading
			// 
			this.txtCurrReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCurrReading.Location = new System.Drawing.Point(938, 429);
			this.txtCurrReading.Name = "txtCurrReading";
			this.txtCurrReading.Size = new System.Drawing.Size(232, 32);
			this.txtCurrReading.TabIndex = 45;
			this.txtCurrReading.TextChanged += new System.EventHandler(this.txtCurrReading_TextChanged);
			this.txtCurrReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrReading_KeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.SlateGray;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Location = new System.Drawing.Point(666, 430);
			this.label10.Margin = new System.Windows.Forms.Padding(0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(227, 31);
			this.label10.TabIndex = 44;
			this.label10.Text = " Current Reading  ";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// updateReadingbtn
			// 
			this.updateReadingbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.updateReadingbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.updateReadingbtn.FlatAppearance.BorderSize = 2;
			this.updateReadingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateReadingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateReadingbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.updateReadingbtn.Location = new System.Drawing.Point(666, 582);
			this.updateReadingbtn.Name = "updateReadingbtn";
			this.updateReadingbtn.Size = new System.Drawing.Size(502, 55);
			this.updateReadingbtn.TabIndex = 46;
			this.updateReadingbtn.Text = "Update Meter Reading";
			this.updateReadingbtn.UseVisualStyleBackColor = false;
			this.updateReadingbtn.Click += new System.EventHandler(this.updateReadingbtn_Click);
			this.updateReadingbtn.MouseEnter += new System.EventHandler(this.updateReadingbtn_MouseEnter);
			this.updateReadingbtn.MouseLeave += new System.EventHandler(this.updateReadingbtn_MouseLeave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(163, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 20);
			this.label3.TabIndex = 47;
			this.label3.Text = "For Information Purpose Only";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(1397, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(269, 20);
			this.label5.TabIndex = 48;
			this.label5.Text = "Select Record to Update its Reading";
			// 
			// lescoDataSet1
			// 
			this.lescoDataSet1.DataSetName = "lescoDataSet";
			this.lescoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// labeleror
			// 
			this.labeleror.AutoSize = true;
			this.labeleror.Enabled = false;
			this.labeleror.ForeColor = System.Drawing.Color.Red;
			this.labeleror.Location = new System.Drawing.Point(907, 529);
			this.labeleror.Name = "labeleror";
			this.labeleror.Size = new System.Drawing.Size(51, 20);
			this.labeleror.TabIndex = 50;
			this.labeleror.Text = "label6";
			this.labeleror.Click += new System.EventHandler(this.labeleror_Click);
			// 
			// updateMeterReading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1786, 848);
			this.Controls.Add(this.labeleror);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.updateReadingbtn);
			this.Controls.Add(this.txtCurrReading);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtReadingId);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.gridviewMeterReading);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.CustomerGridView);
			this.Controls.Add(this.txtReferenceNo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtdate);
			this.Controls.Add(this.txtPrevReading);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "updateMeterReading";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "updateMeterReading";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.updateMeterReading_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerTBLBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lescoDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridviewMeterReading)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lescoDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Label HEADING;
		private lescoDataSet lescoDataSet;
		private System.Windows.Forms.BindingSource customerTBLBindingSource;
		private lescoDataSetTableAdapters.CustomerTBLTableAdapter customerTBLTableAdapter;
		private System.Windows.Forms.DateTimePicker txtdate;
		private System.Windows.Forms.TextBox txtPrevReading;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtReferenceNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView CustomerGridView;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView gridviewMeterReading;
		private System.Windows.Forms.TextBox txtReadingId;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCurrReading;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button updateReadingbtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private lescoDataSet lescoDataSet1;
		private System.Windows.Forms.Label labeleror;
	}
}