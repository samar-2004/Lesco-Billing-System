namespace BillingSystem
{
	partial class billCorrectOptions
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
			this.currReading_radio = new System.Windows.Forms.RadioButton();
			this.tarifRates_radio = new System.Windows.Forms.RadioButton();
			this.bill_radio = new System.Windows.Forms.RadioButton();
			this.units_radio = new System.Windows.Forms.RadioButton();
			this.readingDate_radio = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBillCorrection = new System.Windows.Forms.Button();
			this.radioGroup = new System.Windows.Forms.GroupBox();
			this.backbtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.radioGroup.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(1180, 65);
			this.panel1.TabIndex = 3;
			// 
			// HEADING
			// 
			this.HEADING.AutoSize = true;
			this.HEADING.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HEADING.ForeColor = System.Drawing.Color.Black;
			this.HEADING.Location = new System.Drawing.Point(268, 7);
			this.HEADING.Name = "HEADING";
			this.HEADING.Size = new System.Drawing.Size(577, 46);
			this.HEADING.TabIndex = 0;
			this.HEADING.Text = "LESCO BILLING SYSTEM";
			this.HEADING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// currReading_radio
			// 
			this.currReading_radio.AutoSize = true;
			this.currReading_radio.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.currReading_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currReading_radio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.currReading_radio.Location = new System.Drawing.Point(106, 25);
			this.currReading_radio.Name = "currReading_radio";
			this.currReading_radio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.currReading_radio.Size = new System.Drawing.Size(353, 33);
			this.currReading_radio.TabIndex = 4;
			this.currReading_radio.Text = "Incorrect Current Reading     ";
			this.currReading_radio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.currReading_radio.UseVisualStyleBackColor = false;
			// 
			// tarifRates_radio
			// 
			this.tarifRates_radio.AutoSize = true;
			this.tarifRates_radio.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tarifRates_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tarifRates_radio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tarifRates_radio.Location = new System.Drawing.Point(106, 252);
			this.tarifRates_radio.Name = "tarifRates_radio";
			this.tarifRates_radio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.tarifRates_radio.Size = new System.Drawing.Size(359, 33);
			this.tarifRates_radio.TabIndex = 5;
			this.tarifRates_radio.Text = "Incorrect Tariff Rates Applied";
			this.tarifRates_radio.UseVisualStyleBackColor = false;
			// 
			// bill_radio
			// 
			this.bill_radio.AutoSize = true;
			this.bill_radio.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.bill_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bill_radio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.bill_radio.Location = new System.Drawing.Point(106, 193);
			this.bill_radio.Name = "bill_radio";
			this.bill_radio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.bill_radio.Size = new System.Drawing.Size(356, 33);
			this.bill_radio.TabIndex = 6;
			this.bill_radio.Text = "Incorrect Total Bill                   ";
			this.bill_radio.UseVisualStyleBackColor = false;
			// 
			// units_radio
			// 
			this.units_radio.AutoSize = true;
			this.units_radio.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.units_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.units_radio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.units_radio.Location = new System.Drawing.Point(106, 136);
			this.units_radio.Name = "units_radio";
			this.units_radio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.units_radio.Size = new System.Drawing.Size(354, 33);
			this.units_radio.TabIndex = 7;
			this.units_radio.Text = "Incorrect Units Consumed     ";
			this.units_radio.UseVisualStyleBackColor = false;
			// 
			// readingDate_radio
			// 
			this.readingDate_radio.AutoSize = true;
			this.readingDate_radio.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.readingDate_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.readingDate_radio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.readingDate_radio.Location = new System.Drawing.Point(106, 82);
			this.readingDate_radio.Name = "readingDate_radio";
			this.readingDate_radio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.readingDate_radio.Size = new System.Drawing.Size(354, 33);
			this.readingDate_radio.TabIndex = 8;
			this.readingDate_radio.Text = "Incorrect Reading Date          ";
			this.readingDate_radio.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Purple;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(287, 176);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(5);
			this.label1.Size = new System.Drawing.Size(570, 39);
			this.label1.TabIndex = 9;
			this.label1.Text = "Select One Option You want to Apply for Correction";
			// 
			// btnBillCorrection
			// 
			this.btnBillCorrection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnBillCorrection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnBillCorrection.FlatAppearance.BorderSize = 2;
			this.btnBillCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBillCorrection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBillCorrection.Location = new System.Drawing.Point(331, 580);
			this.btnBillCorrection.Name = "btnBillCorrection";
			this.btnBillCorrection.Size = new System.Drawing.Size(499, 55);
			this.btnBillCorrection.TabIndex = 69;
			this.btnBillCorrection.Text = "Click to Confirm Your Selection";
			this.btnBillCorrection.UseVisualStyleBackColor = false;
			this.btnBillCorrection.Click += new System.EventHandler(this.btnBillCorrection_Click);
			// 
			// radioGroup
			// 
			this.radioGroup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.radioGroup.Controls.Add(this.readingDate_radio);
			this.radioGroup.Controls.Add(this.currReading_radio);
			this.radioGroup.Controls.Add(this.tarifRates_radio);
			this.radioGroup.Controls.Add(this.bill_radio);
			this.radioGroup.Controls.Add(this.units_radio);
			this.radioGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioGroup.Location = new System.Drawing.Point(292, 240);
			this.radioGroup.Name = "radioGroup";
			this.radioGroup.Size = new System.Drawing.Size(565, 304);
			this.radioGroup.TabIndex = 70;
			this.radioGroup.TabStop = false;
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
			// billCorrectOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1180, 720);
			this.Controls.Add(this.radioGroup);
			this.Controls.Add(this.btnBillCorrection);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "billCorrectOptions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "billCorrectOptions  ";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.radioGroup.ResumeLayout(false);
			this.radioGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Label HEADING;
		private System.Windows.Forms.RadioButton currReading_radio;
		private System.Windows.Forms.RadioButton tarifRates_radio;
		private System.Windows.Forms.RadioButton bill_radio;
		private System.Windows.Forms.RadioButton units_radio;
		private System.Windows.Forms.RadioButton readingDate_radio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBillCorrection;
		private System.Windows.Forms.GroupBox radioGroup;
	}
}