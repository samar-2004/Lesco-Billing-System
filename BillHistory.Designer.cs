namespace BillingSystem
{
	partial class BillHistory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.backbtn = new System.Windows.Forms.Button();
			this.HEADING = new System.Windows.Forms.Label();
			this.errorRefernceNo = new System.Windows.Forms.Label();
			this.Viewhistorybtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtReferenceNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.historyGridView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1924, 65);
			this.panel1.TabIndex = 5;
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
			// errorRefernceNo
			// 
			this.errorRefernceNo.AutoSize = true;
			this.errorRefernceNo.Enabled = false;
			this.errorRefernceNo.ForeColor = System.Drawing.Color.Red;
			this.errorRefernceNo.Location = new System.Drawing.Point(686, 506);
			this.errorRefernceNo.Name = "errorRefernceNo";
			this.errorRefernceNo.Size = new System.Drawing.Size(212, 20);
			this.errorRefernceNo.TabIndex = 74;
			this.errorRefernceNo.Text = "* Please Enter integar values";
			// 
			// Viewhistorybtn
			// 
			this.Viewhistorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Viewhistorybtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Viewhistorybtn.FlatAppearance.BorderSize = 2;
			this.Viewhistorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Viewhistorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Viewhistorybtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Viewhistorybtn.Location = new System.Drawing.Point(176, 587);
			this.Viewhistorybtn.Name = "Viewhistorybtn";
			this.Viewhistorybtn.Size = new System.Drawing.Size(504, 55);
			this.Viewhistorybtn.TabIndex = 73;
			this.Viewhistorybtn.Text = "Click to View History";
			this.Viewhistorybtn.UseVisualStyleBackColor = false;
			this.Viewhistorybtn.Click += new System.EventHandler(this.Viewhistorybtn_Click);
			this.Viewhistorybtn.MouseEnter += new System.EventHandler(this.Viewhistorybtn_MouseEnter);
			this.Viewhistorybtn.MouseLeave += new System.EventHandler(this.Viewhistorybtn_MouseLeave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(257, 418);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(373, 26);
			this.label3.TabIndex = 72;
			this.label3.Text = "Enter Your Reference Number Below";
			// 
			// txtReferenceNo
			// 
			this.txtReferenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferenceNo.Location = new System.Drawing.Point(448, 500);
			this.txtReferenceNo.Name = "txtReferenceNo";
			this.txtReferenceNo.Size = new System.Drawing.Size(232, 32);
			this.txtReferenceNo.TabIndex = 71;
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
			this.label1.Location = new System.Drawing.Point(176, 500);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 31);
			this.label1.TabIndex = 70;
			this.label1.Text = " Reference No.     ";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.SlateGray;
			this.panel3.Controls.Add(this.label8);
			this.panel3.Location = new System.Drawing.Point(1057, 207);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(384, 54);
			this.panel3.TabIndex = 75;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(67, 10);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.label8.Size = new System.Drawing.Size(248, 32);
			this.label8.TabIndex = 1;
			this.label8.Text = "Your Bill History";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// historyGridView
			// 
			this.historyGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.historyGridView.AllowUserToAddRows = false;
			this.historyGridView.AllowUserToDeleteRows = false;
			this.historyGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.historyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.historyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.historyGridView.DefaultCellStyle = dataGridViewCellStyle4;
			this.historyGridView.GridColor = System.Drawing.Color.Black;
			this.historyGridView.Location = new System.Drawing.Point(965, 313);
			this.historyGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.historyGridView.Name = "historyGridView";
			this.historyGridView.ReadOnly = true;
			this.historyGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.historyGridView.RowHeadersVisible = false;
			this.historyGridView.RowHeadersWidth = 62;
			this.historyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.historyGridView.Size = new System.Drawing.Size(590, 553);
			this.historyGridView.TabIndex = 76;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1650, 416);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 348);
			this.label2.TabIndex = 77;
			this.label2.Text = "1     January\r\n2     February\r\n3     March\r\n4     April\r\n5     May\r\n6     June\r\n7" +
    "     July \r\n8     August\r\n9     September\r\n10   October\r\n11   November\r\n12   Dec" +
    "ember";
			// 
			// BillHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1924, 939);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.historyGridView);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.errorRefernceNo);
			this.Controls.Add(this.Viewhistorybtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtReferenceNo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "BillHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BillHistory";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.Label errorRefernceNo;
		private System.Windows.Forms.Button Viewhistorybtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtReferenceNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView historyGridView;
		private System.Windows.Forms.Label label2;
	}
}