namespace BillingSystem
{
	partial class mainform
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
			this.adminbtn = new System.Windows.Forms.Button();
			this.customerbtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.HEADING);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1671, 65);
			this.panel1.TabIndex = 0;
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
			// adminbtn
			// 
			this.adminbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.adminbtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.adminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminbtn.ForeColor = System.Drawing.SystemColors.Control;
			this.adminbtn.Location = new System.Drawing.Point(855, 242);
			this.adminbtn.Name = "adminbtn";
			this.adminbtn.Size = new System.Drawing.Size(219, 53);
			this.adminbtn.TabIndex = 1;
			this.adminbtn.Text = "ADMIN";
			this.adminbtn.UseVisualStyleBackColor = false;
			this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
			// 
			// customerbtn
			// 
			this.customerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.customerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.customerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerbtn.ForeColor = System.Drawing.SystemColors.Control;
			this.customerbtn.Location = new System.Drawing.Point(855, 383);
			this.customerbtn.Name = "customerbtn";
			this.customerbtn.Size = new System.Drawing.Size(219, 53);
			this.customerbtn.TabIndex = 2;
			this.customerbtn.Text = "Customer";
			this.customerbtn.UseVisualStyleBackColor = false;
			this.customerbtn.Click += new System.EventHandler(this.customerbtn_Click);
			// 
			// mainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = global::BillingSystem.Properties.Resources.backgorund_image;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(1671, 964);
			this.Controls.Add(this.customerbtn);
			this.Controls.Add(this.adminbtn);
			this.Controls.Add(this.panel1);
			this.Name = "mainform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Form";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.Button adminbtn;
		private System.Windows.Forms.Button customerbtn;
	}
}

