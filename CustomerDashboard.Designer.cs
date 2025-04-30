namespace BillingSystem
{
	partial class CustomerDashboard
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
			this.viewBillHistory = new System.Windows.Forms.Button();
			this.viewCUrrentBillbtn = new System.Windows.Forms.Button();
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
			this.panel1.Size = new System.Drawing.Size(1579, 65);
			this.panel1.TabIndex = 1;
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
			// viewBillHistory
			// 
			this.viewBillHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.viewBillHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.viewBillHistory.FlatAppearance.BorderSize = 2;
			this.viewBillHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.viewBillHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewBillHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.viewBillHistory.Image = global::BillingSystem.Properties.Resources.history__1_;
			this.viewBillHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.viewBillHistory.Location = new System.Drawing.Point(738, 431);
			this.viewBillHistory.Name = "viewBillHistory";
			this.viewBillHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.viewBillHistory.Size = new System.Drawing.Size(469, 102);
			this.viewBillHistory.TabIndex = 7;
			this.viewBillHistory.Text = "View Bill History";
			this.viewBillHistory.UseVisualStyleBackColor = false;
			this.viewBillHistory.Click += new System.EventHandler(this.viewBillHistory_Click);
			this.viewBillHistory.MouseEnter += new System.EventHandler(this.viewBillHistory_MouseEnter);
			this.viewBillHistory.MouseLeave += new System.EventHandler(this.viewBillHistory_MouseLeave);
			// 
			// viewCUrrentBillbtn
			// 
			this.viewCUrrentBillbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.viewCUrrentBillbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.viewCUrrentBillbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.viewCUrrentBillbtn.FlatAppearance.BorderSize = 2;
			this.viewCUrrentBillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.viewCUrrentBillbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewCUrrentBillbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.viewCUrrentBillbtn.Image = global::BillingSystem.Properties.Resources.table__2___1_;
			this.viewCUrrentBillbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.viewCUrrentBillbtn.Location = new System.Drawing.Point(738, 283);
			this.viewCUrrentBillbtn.Name = "viewCUrrentBillbtn";
			this.viewCUrrentBillbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.viewCUrrentBillbtn.Size = new System.Drawing.Size(469, 102);
			this.viewCUrrentBillbtn.TabIndex = 6;
			this.viewCUrrentBillbtn.Text = "View current Bill";
			this.viewCUrrentBillbtn.UseVisualStyleBackColor = false;
			this.viewCUrrentBillbtn.Click += new System.EventHandler(this.viewRecordsbtn_Click);
			this.viewCUrrentBillbtn.MouseEnter += new System.EventHandler(this.viewCUrrentBillbtn_MouseEnter);
			this.viewCUrrentBillbtn.MouseLeave += new System.EventHandler(this.viewCUrrentBillbtn_MouseLeave);
			// 
			// backbtn
			// 
			this.backbtn.BackColor = System.Drawing.Color.DarkGreen;
			this.backbtn.BackgroundImage = global::BillingSystem.Properties.Resources.back_button;
			this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.backbtn.ForeColor = System.Drawing.Color.Crimson;
			this.backbtn.Location = new System.Drawing.Point(39, 7);
			this.backbtn.Name = "backbtn";
			this.backbtn.Size = new System.Drawing.Size(44, 42);
			this.backbtn.TabIndex = 3;
			this.backbtn.UseVisualStyleBackColor = false;
			this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
			// 
			// CustomerDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1579, 784);
			this.Controls.Add(this.viewBillHistory);
			this.Controls.Add(this.viewCUrrentBillbtn);
			this.Controls.Add(this.panel1);
			this.Name = "CustomerDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CustomerDashboard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.Button viewCUrrentBillbtn;
		private System.Windows.Forms.Button viewBillHistory;
		private System.Windows.Forms.Button backbtn;
	}
}