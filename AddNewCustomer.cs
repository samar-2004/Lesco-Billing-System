using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace BillingSystem
{

	public partial class AddNewCustomer : Form
	{
		string connectionString_ = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
		public AddNewCustomer()
		{
			InitializeComponent();
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			AdminDashBoard adminDashBoard = new AdminDashBoard();
			adminDashBoard.Show();
		}

		private void AddCustomerbtn_MouseEnter(object sender, EventArgs e)
		{
			AddCustomerbtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void AddCustomerbtn_MouseLeave(object sender, EventArgs e)
		{

			AddCustomerbtn.FlatAppearance.BorderColor = Color.White;
		}
		int GetLastReferenceNumber()
		{
			int lastRefNum = 0; 
			string connectionString = connectionString_;
			string query = "SELECT MAX(ReferenceNumber) FROM CustomerTBL";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					conn.Open();
					object result = cmd.ExecuteScalar();
					if (result != null && result != DBNull.Value)
					{
						lastRefNum = Convert.ToInt32(result);
					}
				}
			}

			return lastRefNum;
		}
		private void AddCustomerbtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtName.Text) ||
				string.IsNullOrWhiteSpace(txtAddress.Text) ||
				string.IsNullOrWhiteSpace(txtPhoneNo.Text) ||
				string.IsNullOrWhiteSpace(txtdate.Text) ||
				string.IsNullOrWhiteSpace(txtMeterReading.Text))
			{
				MessageBox.Show("Please fill in all the fields.");
				return;
			}

			try
			{
				int newRefNum = GetLastReferenceNumber() + 1;
				string connectionString = connectionString_;

				string insertCustomerQuery = "INSERT INTO CustomerTBL (ReferenceNumber, Name, Address, PhoneNo, InstallationDate, MeterReading) " +
					"VALUES (@refNum, @name, @address, @phone, @date, @reading)";

				string insertMeterReadingQuery = "INSERT INTO MeterReadings (ReferenceNumber, ReadingDate, PreviousReading, CurrentReading, Month) " +
					"VALUES (@refNum, @date, @reading, @reading, DATEPART(MONTH, @date))";

				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmdCustomer = new SqlCommand(insertCustomerQuery, conn))
					{
						cmdCustomer.Parameters.AddWithValue("@refNum", newRefNum);
						cmdCustomer.Parameters.AddWithValue("@name", txtName.Text);
						cmdCustomer.Parameters.AddWithValue("@address", txtAddress.Text);
						cmdCustomer.Parameters.AddWithValue("@phone", txtPhoneNo.Text);
						cmdCustomer.Parameters.AddWithValue("@date", txtdate.Value.ToString("yyyy-MM-dd"));
						cmdCustomer.Parameters.AddWithValue("@reading", txtMeterReading.Text);

						cmdCustomer.ExecuteNonQuery();
					}

					using (SqlCommand cmdMeterReading = new SqlCommand(insertMeterReadingQuery, conn))
					{
						cmdMeterReading.Parameters.AddWithValue("@refNum", newRefNum);
						cmdMeterReading.Parameters.AddWithValue("@date", txtdate.Value.ToString("yyyy-MM-dd"));
						cmdMeterReading.Parameters.AddWithValue("@reading", txtMeterReading.Text);

						cmdMeterReading.ExecuteNonQuery();
					}
				}
				MessageBox.Show($"Customer with reference number {newRefNum} is Added.");
				txtName.Clear();
				txtAddress.Clear();
				txtPhoneNo.Clear();
				txtMeterReading.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}
		}


		private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
		{ 
				if ((!char.IsDigit(e.KeyChar) || txtPhoneNo.Text.Length >= 11) && e.KeyChar != (char)Keys.Back) 
				{
					e.Handled = true; 
				    lbPhoneError.ForeColor = Color.Red;
				     lbPhoneError.Text = "* Phone number must be in digits and 11 digits long.";
					lbPhoneError.Enabled = true;
				}
				else
				{
				     lbPhoneError.Enabled = false; 
				}
		}

		private void txtMeterReading_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
				lblMeterError.ForeColor = Color.Red;
				lblMeterError.Text = "* Meter Reading must be in digits.";
				lblMeterError.Enabled = true;
			}
			else
			{
				lblMeterError.Enabled = false;
			}
		}
	}
}
