using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillingSystem
{
	public partial class currentBill : Form
	{
		string connection_ = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
		public currentBill()
		{
			InitializeComponent();
		}

		private void ViewBillbtn_MouseEnter(object sender, EventArgs e)
		{
			ViewBillbtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void ViewBillbtn_MouseLeave(object sender, EventArgs e)
		{
			ViewBillbtn.FlatAppearance.BorderColor = Color.White;
		}

		private void btnBillCorrection_MouseEnter(object sender, EventArgs e)
		{
			btnBillCorrection.FlatAppearance.BorderColor = Color.Violet;
		}

		private void btnBillCorrection_MouseLeave(object sender, EventArgs e)
		{
			btnBillCorrection.FlatAppearance.BorderColor = Color.White;
		}

		private void ViewBillbtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtReferenceNo.Text) || !int.TryParse(txtReferenceNo.Text, out int referenceNumber))
			{
				MessageBox.Show("Please enter a valid reference number.");
				return;
			}
			else
			{
				using (SqlConnection connection = new SqlConnection(connection_))
				{
					connection.Open();

					string customerQuery = "SELECT Name, Address FROM CustomerTBL WHERE ReferenceNumber = @ReferenceNumber";
					using (SqlCommand customerCommand = new SqlCommand(customerQuery, connection))
					{
						customerCommand.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
						SqlDataReader customerReader = customerCommand.ExecuteReader();
						if (customerReader.Read())
						{
							txtname.Text = customerReader["Name"].ToString();
							txtAddress.Text = customerReader["Address"].ToString();
						}
						else
						{
							MessageBox.Show("Customer data not found for the entered reference number.");

							txtname.Clear();
							txtAddress.Clear();

							customerReader.Close();
							return;
						}
						customerReader.Close();
					}

					string billingQuery  = "SELECT TOP 1 CurrentReading, UnitsConsumed, DueDate, BillAmount, BillGenerationDate " +
								  "FROM MonthlyBilling " +
								  "WHERE ReferenceNumber = @ReferenceNumber " +
								  "ORDER BY DateOfReading DESC";
					using (SqlCommand billingCommand = new SqlCommand(billingQuery, connection))
					{
						billingCommand.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
						SqlDataReader billingReader = billingCommand.ExecuteReader();
						if (billingReader.Read())
						{
							txtCurrReading.Text = billingReader["CurrentReading"].ToString();
							txtUnits.Text = billingReader["UnitsConsumed"].ToString();
							txtDueDate.Text = billingReader["DueDate"].ToString();
							txttotalbill.Text = billingReader["BillAmount"].ToString();
							txtReadingDate.Text = billingReader["BillGenerationDate"].ToString();

							decimal totalBillAmount = Convert.ToDecimal(billingReader["BillAmount"]);
							decimal unitsConsumed = Convert.ToDecimal(billingReader["UnitsConsumed"]);

							if (unitsConsumed <= 300)
							{
								decimal percentIncrease = 4m;
								decimal increaseAmount = (percentIncrease / 100) * totalBillAmount;
								decimal billAfterDueDate = totalBillAmount + increaseAmount;
								txtLatePayment.Text = billAfterDueDate.ToString();
							}
							else if (unitsConsumed > 300)
							{
								decimal percentIncrease = 10m;
								decimal increaseAmount = (percentIncrease / 100) * totalBillAmount;
								decimal billAfterDueDate = totalBillAmount + increaseAmount;
								txtLatePayment.Text = billAfterDueDate.ToString();
							}
						}
						else
						{
							MessageBox.Show("Monthly billing data not found for the entered reference number.");

							txtCurrReading.Clear();
							txtname.Clear();
							txtAddress.Clear();
							txtUnits.Clear();
							txtDueDate.Clear();
							txttotalbill.Clear();
							txtReadingDate.Clear();
							txtLatePayment.Clear();

							billingReader.Close();
							return;
						}
						billingReader.Close();
					}
				}
			}
		}

		private void txtReferenceNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
				errorRefernceNo.Enabled = true;
			}
			else
			{
				errorRefernceNo.Enabled = false;
			}
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			CustomerDashboard customerDashboard = new CustomerDashboard();
			customerDashboard.Show();
		}
		private void btnBillCorrection_Click(object sender, EventArgs e)
		{
			string referenceNo = txtReferenceNo.Text;

			if (IsReferenceNumberValid(referenceNo))
			{
				billCorrectOptions billCorrectOptionsForm = new billCorrectOptions(referenceNo);
				billCorrectOptionsForm.Show();
			}
			else
			{
				MessageBox.Show("Invalid reference number. Please enter a valid reference number.");
			}
		}

		private bool IsReferenceNumberValid(string referenceNo)
		{
			string connectionString = connection_;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT COUNT(*) FROM MonthlyBilling WHERE ReferenceNumber = @ReferenceNumber";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ReferenceNumber", referenceNo);

					int count = (int)command.ExecuteScalar();

					return count > 0;
				}
			}
		}
		private void btnViewTarrifRates_MouseEnter(object sender, EventArgs e)
		{
			btnViewTarrifRates.FlatAppearance.BorderColor = Color.Violet;
		}

		private void btnViewTarrifRates_MouseLeave(object sender, EventArgs e)
		{

			btnViewTarrifRates.FlatAppearance.BorderColor = Color.White;
    	}

		private void btnViewTarrifRates_Click(object sender, EventArgs e)
		{
			tariifRates tariifRates = new tariifRates();
			tariifRates.Show();
		}
	}
}
