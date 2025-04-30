using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
	public partial class payment : Form
	{
		string connectionstring_ = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
		public payment()
		{
			InitializeComponent();
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			AdminDashBoard adminDashBoard = new AdminDashBoard();
			adminDashBoard.Show();
		}


		private void LoadDataInGRidVIew()
		{
			string connectionString = connectionstring_;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					string sqlQuery = "SELECT ReadingID, ReferenceNumber, DateOfReading, UnitsConsumed, BillAmount, DueDate, Payment, PaymentStatus, PaymentDate FROM MonthlyBilling";
					using (SqlCommand command = new SqlCommand(sqlQuery, connection))
					{
						DataTable dataTable = new DataTable();
						SqlDataAdapter adapter = new SqlDataAdapter(command);
						adapter.Fill(dataTable);
						gridviewMonthlyReading.DataSource = dataTable;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred: " + ex.Message);
				}
			}
		}
		private void payment_Load(object sender, EventArgs e)
		{
			LoadDataInGRidVIew();
		}
		private void gridviewMonthlyReading_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = gridviewMonthlyReading.Rows[e.RowIndex];
				string paymentStatus = selectedRow.Cells["PaymentStatus"].Value.ToString();
				if (paymentStatus == "paid")
				{
					MessageBox.Show("The Bill of the selected record is already Paid.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return; 
				}
				txtReadingId.Text = selectedRow.Cells["ReadingID"].Value.ToString();
				txtReferenceNo.Text = selectedRow.Cells["ReferenceNumber"].Value.ToString();
				txtUnitsConsumed.Text = selectedRow.Cells["UnitsConsumed"].Value.ToString();
				txtReadingDate.Value = Convert.ToDateTime(selectedRow.Cells["DateOfReading"].Value);
				txtDuedate.Value = Convert.ToDateTime(selectedRow.Cells["DueDate"].Value);
				txtpaymentdate.Value = Convert.ToDateTime(selectedRow.Cells["DateOfReading"].Value);
				txtBillAmount.Text = selectedRow.Cells["BillAmount"].Value.ToString();
			}
		}
		private void txtpaymentdate_ValueChanged(object sender, EventArgs e)
		{
			DateTime selectedPaymentDate = txtpaymentdate.Value;
			DateTime readingDate = txtReadingDate.Value;
			if (selectedPaymentDate < readingDate)
			{
				MessageBox.Show("Payment date cannot be earlier than reading date.");
				txtpaymentdate.Value = readingDate;
			}
		}

		private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}
		private void updateReadingbtn_MouseEnter(object sender, EventArgs e)
		{
			AddPaymntbtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void AddPaymntbtn_MouseLeave(object sender, EventArgs e)
		{
			AddPaymntbtn.FlatAppearance.BorderColor = Color.White;
		}








		private bool CheckUnpaidBillsExist(int readingID,string referenceNumber)
		{
			string query = "SELECT TOP 1 ReferenceNumber FROM MonthlyBilling " +
			   "WHERE ReferenceNumber = @ReferenceNumber " +
			   "AND PaymentStatus = 'Unpaid' " +
			   "AND DateOfReading < (SELECT DateOfReading FROM MonthlyBilling WHERE ReadingID = @ReadingID)";

			using (SqlConnection connection = new SqlConnection(connectionstring_))
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
				command.Parameters.AddWithValue("@ReadingID", readingID);

				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();

					// If any unpaid bills before the specified ReadingID are found, return true
					return reader.HasRows;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
					return false;
				}
			}
		}


		private void AddPaymntbtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtPayment.Text))
			{
				MessageBox.Show("Please add the Paid Amount of the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!decimal.TryParse(txtPayment.Text, out decimal paidAmount))
			{
				MessageBox.Show("Invalid Paid Amount. Please enter a valid numeric amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!decimal.TryParse(txtBillAmount.Text, out decimal billAmount))
			{
				MessageBox.Show("Invalid Bill Amount. Please enter a valid numeric amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!DateTime.TryParse(txtDuedate.Text, out DateTime dueDate))
			{
				MessageBox.Show("Invalid Due Date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!DateTime.TryParse(txtpaymentdate.Text, out DateTime paymentDate))
			{
				MessageBox.Show("Invalid Payment Date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int readingId = int.Parse(txtReadingId.Text);

			bool unpaidBillsExist = CheckUnpaidBillsExist(readingId,txtReferenceNo.Text);

			if (unpaidBillsExist)
			{
				MessageBox.Show("There are unpaid bills for this reference number. Please ask the customer to pay the previous bills first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				ProcessPayment(txtReadingId.Text, txtReferenceNo.Text, paidAmount, paymentDate, billAmount, dueDate);
			}
		}



		private void ProcessPayment(string readingId, string referenceNumber, decimal paidAmount, DateTime paymentDate, decimal billAmount, DateTime dueDate)
		{


			if (paymentDate <= dueDate)
			{
				if ((int)paidAmount != (int)billAmount)
				{
					MessageBox.Show($"Incorrect Paid Amount. Please enter {(int)billAmount:C} in Paid Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else if ((int)paidAmount == (int)billAmount)
				{
					MessageBox.Show("Payment done successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					UpdateMonthlyBilling(txtReadingId.Text, txtReferenceNo.Text, paidAmount, paymentDate);
					return;
				}
			}
			double totalAmount = 0;
			if (paymentDate > dueDate)
			{
				double extraPercentage = (txtUnitsConsumed.Text.Length > 0 && int.TryParse(txtUnitsConsumed.Text, out int unitsConsumed) && unitsConsumed > 300) ? 0.1 : 0.04;
				double extraAmount = (int)billAmount * extraPercentage;
				totalAmount = (int)billAmount + extraAmount;

				MessageBox.Show($"The customer is paying the bill after the due date. The Bill Amount with extra charges is: {(int)totalAmount:C}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

				if ((int)totalAmount != (int)paidAmount)
				{
					MessageBox.Show($"Incorrect Paid Amount. Please enter {(int)totalAmount:C} in Paid Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if ((int)totalAmount == (int)paidAmount)
				{
					MessageBox.Show("Payment done successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					UpdateMonthlyBilling(txtReadingId.Text, txtReferenceNo.Text, paidAmount, paymentDate);
				}
			}

		}

		private void UpdateMonthlyBilling(string readingId, string referenceNo, decimal paidAmount, DateTime paymentDate)
		{
			string connectionString = connectionstring_;

			string updateQuery = @" UPDATE MonthlyBilling
                    SET Payment = @PaidAmount, PaymentStatus = 'paid', PaymentDate = @PaymentDate
                     WHERE ReadingID = @ReadingId AND ReferenceNumber = @ReferenceNo";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(updateQuery, connection))
				{
					command.Parameters.AddWithValue("@PaidAmount", paidAmount);
					command.Parameters.AddWithValue("@PaymentDate", paymentDate);
					command.Parameters.AddWithValue("@ReadingId", readingId);
					command.Parameters.AddWithValue("@ReferenceNo", referenceNo);
					try
					{
						connection.Open();
						int rowsAffected = command.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("MonthlyBilling table updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadDataInGRidVIew();
							clearTextBoxes();
						}
						else
						{
							MessageBox.Show("No records updated. ReadingID and ReferenceNumber not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Error updating MonthlyBilling table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void clearTextBoxes()
		{
			foreach (Control control in this.Controls)
			{
				if (control is TextBox)
				{
					((TextBox)control).Clear();
				}
			}
		}
	}
}
