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
	public partial class updateMeterReading : Form
	{
		string connectionstring_ = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
		public updateMeterReading()
		{
			InitializeComponent();
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			AdminDashBoard adminDashBoard = new AdminDashBoard();
			adminDashBoard.Show();
		}

		private void loadCustomerData()
		{
			string connectionString = connectionstring_;
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			string query = "SELECT * FROM CustomerTBL";
			SqlCommand command = new SqlCommand(query, connection);
			DataTable dataTable = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dataTable);
			CustomerGridView.DataSource = dataTable;
			connection.Close();
		}

		private void loadMeterReadings()
		{
			string connectionString = connectionstring_;
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			string query = "SELECT * FROM MeterReadings";
			SqlCommand command = new SqlCommand(query, connection);
			DataTable dataTable = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dataTable);
			gridviewMeterReading.DataSource = dataTable;
			connection.Close();
		}

		private void updateMeterReading_Load(object sender, EventArgs e)
		{
			loadCustomerData();

			loadMeterReadings();
		}

		private void updateReadingbtn_MouseEnter(object sender, EventArgs e)
		{
			updateReadingbtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void updateReadingbtn_MouseLeave(object sender, EventArgs e)
		{
			updateReadingbtn.FlatAppearance.BorderColor = Color.White;
		}
		private DataGridViewRow selectedRow;
		private void gridviewMeterReading_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >= 0)
			{
				selectedRow = gridviewMeterReading.Rows[e.RowIndex];

				txtReadingId.Text = selectedRow.Cells["ReadingID"].Value.ToString();
				txtReferenceNo.Text = selectedRow.Cells["ReferenceNumber"].Value.ToString();
				txtPrevReading.Text = selectedRow.Cells["CurrentReading"].Value.ToString();
				txtdate.Text = selectedRow.Cells["ReadingDate"].Value.ToString();
			}
			else
			{
				txtReadingId.Clear();
				txtReferenceNo.Clear();
				txtPrevReading.Clear();
				txtCurrReading.Clear();
			}
		}

		decimal calculate_bill(decimal unitsConsumed)
		{
			decimal billAmount = 0;

			if (unitsConsumed <= 100)
			{
				billAmount = unitsConsumed * 10;
			}
			else if (unitsConsumed <= 200)
			{
				billAmount = 100 * 10 + (unitsConsumed - 100) * 15;
			}
			else if (unitsConsumed <= 300)
			{
				billAmount = 100 * 10 + 100 * 15 + (unitsConsumed - 200) * 20;
			}
			else if (unitsConsumed <= 500)
			{
				billAmount = unitsConsumed * 30;
			}
			else if (unitsConsumed <= 1000)
			{
				billAmount = unitsConsumed * 40;
			}
			else if (unitsConsumed > 1000)
			{
				billAmount = unitsConsumed * 60;
			}

			return billAmount;
		}


		void UpdateMonthlyBilling()
		{
			if (selectedRow == null)
			{
				MessageBox.Show("Please select a record first.");
				return;
			}

			int readingID = Convert.ToInt32(selectedRow.Cells["ReadingID"].Value);
			int referenceNumber = Convert.ToInt32(selectedRow.Cells["ReferenceNumber"].Value);
			DateTime readingDate = txtdate.Value;
			decimal currentReading = Convert.ToDecimal(txtCurrReading.Text);

			DateTime billGenerationDate = readingDate;
			DateTime dueDate = billGenerationDate.AddDays(7);

			string checkQuery = "SELECT COUNT(*) FROM MonthlyBilling WHERE ReferenceNumber = @ReferenceNumber AND Month = @Month";

			using (SqlConnection connection = new SqlConnection(connectionstring_))
			{
				connection.Open();

				using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
				{
					checkCommand.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
					checkCommand.Parameters.AddWithValue("@Month", readingDate.Month);

					int existingRecordsCount = (int)checkCommand.ExecuteScalar();

					if (existingRecordsCount > 0)
					{

						string selectPreviousReadingQuery = "SELECT PreviousReading FROM MonthlyBilling WHERE ReferenceNumber = @ReferenceNumber AND Month = @Month";
						using (SqlCommand selectPreviousReadingCommand = new SqlCommand(selectPreviousReadingQuery, connection))
						{
							selectPreviousReadingCommand.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
							selectPreviousReadingCommand.Parameters.AddWithValue("@Month", readingDate.Month);

							object previousReadingObj = selectPreviousReadingCommand.ExecuteScalar();

							if (previousReadingObj != null && decimal.TryParse(previousReadingObj.ToString(), out decimal previousReading))
							{
								decimal unitsConsumed = currentReading - previousReading;

								decimal billAmount = calculate_bill(unitsConsumed);

								string updateQuery = "UPDATE MonthlyBilling " +
											 "SET CurrentReading = @CurrentReading, DateOfReading = @DateOfReading , " +
											 "UnitsConsumed = @UnitsConsumed, " +
											 "BillAmount = @BillAmount, " +
											 "BillGenerationDate = @BillGenerationDate, " +
											 "DueDate = @DueDate ,  PaymentStatus = 'unpaid'" +
											 "WHERE ReferenceNumber = @ReferenceNumber AND Month = @Month";

								using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
								{
									updateCommand.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
									updateCommand.Parameters.AddWithValue("@Month", readingDate.Month);
									updateCommand.Parameters.AddWithValue("@CurrentReading", currentReading);
									updateCommand.Parameters.AddWithValue("@DateOfReading", readingDate);
									updateCommand.Parameters.AddWithValue("@UnitsConsumed", unitsConsumed);
									updateCommand.Parameters.AddWithValue("@BillAmount", billAmount);
									updateCommand.Parameters.AddWithValue("@BillGenerationDate", billGenerationDate);
									updateCommand.Parameters.AddWithValue("@DueDate", dueDate);

									int rowsAffected = updateCommand.ExecuteNonQuery();

									if (rowsAffected > 0)
									{
										MessageBox.Show("Monthly billing record updated successfully.");
									}
									else
									{
										MessageBox.Show("No records were updated.");
									}
								}
							}
						}
					}
					else
					{
						decimal previousReading = Convert.ToDecimal(txtPrevReading.Text);
						decimal unitsConsumed = currentReading - previousReading;
						decimal billAmount = calculate_bill(unitsConsumed);

						string insertQuery = "INSERT INTO MonthlyBilling (ReferenceNumber,DateOfReading, Month, PreviousReading, " +
											 "CurrentReading, UnitsConsumed, BillAmount, BillGenerationDate, DueDate ,PaymentStatus) " +
											 "VALUES (@ReferenceNumber,@DateOfReading,@Month, @PreviousReading, @CurrentReading, " +
											 "@UnitsConsumed, @BillAmount, @BillGenerationDate, @DueDate , 'unpaid')";

						using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
						{
							insertCommand.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
							insertCommand.Parameters.AddWithValue("@DateOfReading", readingDate);
							insertCommand.Parameters.AddWithValue("@Month", readingDate.Month);
							insertCommand.Parameters.AddWithValue("@PreviousReading", previousReading);
							insertCommand.Parameters.AddWithValue("@CurrentReading", currentReading);
							insertCommand.Parameters.AddWithValue("@UnitsConsumed", unitsConsumed);
							insertCommand.Parameters.AddWithValue("@BillAmount", billAmount);
							insertCommand.Parameters.AddWithValue("@BillGenerationDate", billGenerationDate);
							insertCommand.Parameters.AddWithValue("@DueDate", dueDate);

							int rowsAffected = insertCommand.ExecuteNonQuery();

							if (rowsAffected > 0)
							{
								MessageBox.Show("New monthly billing record inserted successfully.");
							}
							else
							{
								MessageBox.Show("No records were inserted.");
							}
						}
					}
				}
			}
		}

		void update_MeterReadings()
		{
			if (selectedRow == null)
			{
				MessageBox.Show("Please select a record first.");
				return;
			}

			string currentReading_ = txtCurrReading.Text.Trim();

			if (string.IsNullOrEmpty(currentReading_))
			{
				MessageBox.Show("Please enter the current reading to update.");
				return;
			}

			string connectionString = connectionstring_;
			string updateQuery = "UPDATE MeterReadings SET CurrentReading = @CurrentReading, PreviousReading = @PreviousReading , ReadingDate = @date , Month = DATEPART(MONTH, @date) WHERE ReadingID = @ReadingID";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(updateQuery, connection))
				{
					string currentReading = txtCurrReading.Text;
					string previousReading = txtPrevReading.Text;

					command.Parameters.AddWithValue("@ReadingID", txtReadingId.Text);
					command.Parameters.AddWithValue("@CurrentReading", txtCurrReading.Text);
					command.Parameters.AddWithValue("@PreviousReading", txtPrevReading.Text);
					command.Parameters.AddWithValue("@date", txtdate.Value.ToString("yyyy-MM-dd"));

					int rowsAffected = command.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						UpdateMonthlyBilling();
						MessageBox.Show("Reading updated successfully.");
						loadMeterReadings();
						txtReadingId.Clear();
						txtReferenceNo.Clear();
						txtPrevReading.Clear();
						txtCurrReading.Clear();
					}
					else
					{
						MessageBox.Show("No records were updated.");
					}
				}
			}
		}
		private void updateReadingbtn_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(txtPrevReading.Text, out decimal previousReading) &&
				decimal.TryParse(txtCurrReading.Text, out decimal currentReading))
			{
				if (currentReading <= previousReading)
				{
					labeleror.Text = "Current reading must be greater than the previous reading.";
					labeleror.Enabled = true;

					txtCurrReading.Clear();
					return;
				}
			}
			else
			{
				labeleror.Text = "Invalid input. Please enter valid numbers.";
				labeleror.Enabled = true;

				return;
			}

			labeleror.Enabled = false;
			update_MeterReadings();
		}


		private void txtCurrReading_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
			else if (e.KeyChar == '-' || e.KeyChar == '.')
			{
				e.Handled = true;
			}
		}

		private void lblerror_Click(object sender, EventArgs e)
		{

		}

		private void labeleror_Click(object sender, EventArgs e)
		{

		}

		private void txtCurrReading_TextChanged(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void txtReadingId_TextChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void txtReferenceNo_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txtdate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void txtPrevReading_TextChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		//private void txtdate_ValueChanged(object sender, EventArgs e)
		//{
		//	if (isInitializing)
		//	{
		//		// Do nothing during initialization
		//		return;
		//	}
		//	DateTime selectedDate = txtdate.Value;

		//	// Check if the selected date is in the future (next month) and not the last day of the previous month
		//	if (selectedDate > DateTime.Now && !IsLastDayOfPreviousMonth(previousReadingDate))
		//	{
		//		MessageBox.Show("You cannot update the reading on the next month until it is the last day of the previous month.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

		//		// Reset the DateTimePicker value to the previous reading date
		//		txtdate.Value = previousReadingDate;
		//	}
		//}
	}
}
