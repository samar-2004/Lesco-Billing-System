namespace BillingSystem
{
	partial class viewRecords
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.HEADING = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.CustomerGridView = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.billingGridView = new System.Windows.Forms.DataGridView();
			this.backbtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.billingGridView)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1852, 65);
			this.panel1.TabIndex = 3;
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
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SlateGray;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(352, 291);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(384, 38);
			this.panel2.TabIndex = 41;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(76, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer Details";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CustomerGridView
			// 
			this.CustomerGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.CustomerGridView.AllowUserToAddRows = false;
			this.CustomerGridView.AllowUserToDeleteRows = false;
			this.CustomerGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.CustomerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.CustomerGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.CustomerGridView.GridColor = System.Drawing.Color.Black;
			this.CustomerGridView.Location = new System.Drawing.Point(256, 351);
			this.CustomerGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CustomerGridView.Name = "CustomerGridView";
			this.CustomerGridView.ReadOnly = true;
			this.CustomerGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.CustomerGridView.RowHeadersVisible = false;
			this.CustomerGridView.RowHeadersWidth = 62;
			this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CustomerGridView.Size = new System.Drawing.Size(590, 500);
			this.CustomerGridView.TabIndex = 40;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.SlateGray;
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(1195, 288);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(384, 38);
			this.panel3.TabIndex = 43;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(109, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Billing Details";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// billingGridView
			// 
			this.billingGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.billingGridView.AllowUserToAddRows = false;
			this.billingGridView.AllowUserToDeleteRows = false;
			this.billingGridView.AllowUserToResizeColumns = false;
			this.billingGridView.AllowUserToResizeRows = false;
			this.billingGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.billingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.billingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.billingGridView.DefaultCellStyle = dataGridViewCellStyle4;
			this.billingGridView.GridColor = System.Drawing.Color.Black;
			this.billingGridView.Location = new System.Drawing.Point(1099, 348);
			this.billingGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.billingGridView.Name = "billingGridView";
			this.billingGridView.ReadOnly = true;
			this.billingGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.billingGridView.RowHeadersVisible = false;
			this.billingGridView.RowHeadersWidth = 62;
			this.billingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.billingGridView.Size = new System.Drawing.Size(590, 500);
			this.billingGridView.TabIndex = 42;
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
			// viewRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1852, 1050);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.billingGridView);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.CustomerGridView);
			this.Controls.Add(this.panel1);
			this.Name = "viewRecords";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "viewRecords";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.viewRecords_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.billingGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView CustomerGridView;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView billingGridView;
	}
}