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
	public partial class billCorrection : Form
	{
		public billCorrection()
		{
			InitializeComponent();
		}

		private void billCorrection_Load(object sender, EventArgs e)
		{
			try
			{
				string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					string query = "SELECT CorrectionID, ReferenceNumber, Correction, CorrectionConfirmed FROM billCorrectedOptions";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						using (SqlDataAdapter adapter = new SqlDataAdapter(command))
						{
							DataTable dataTable = new DataTable();
							adapter.Fill(dataTable);

							CorrectionReqGridView.DataSource = dataTable;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			AdminDashBoard adminDashBoard = new AdminDashBoard();
			adminDashBoard.Show();	
		}

		private void AcceptReqBtn_Click(object sender, EventArgs e)
		{
			if (CorrectionReqGridView.SelectedRows.Count > 0)
			{
				int referenceNumber = Convert.ToInt32(CorrectionReqGridView.SelectedRows[0].Cells["ReferenceNumber"].Value);

				if (IsCorrectionRequested(referenceNumber))
				{
					MessageBox.Show("Bill correction request for Reference Number: " + referenceNumber + " has already been accepted.");
					return;
				}

				DialogResult result = MessageBox.Show("Do you want to accept the bill correction request for Reference Number: " + referenceNumber + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					try
					{
						string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
						using (SqlConnection connection = new SqlConnection(connectionString))
						{
							connection.Open();

							string updateQuery = "UPDATE billCorrectedOptions SET CorrectionConfirmed = 1 WHERE ReferenceNumber = @ReferenceNumber";
							using (SqlCommand command = new SqlCommand(updateQuery, connection))
							{
								command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
								int rowsAffected = command.ExecuteNonQuery();

								if (rowsAffected > 0)
								{
									MessageBox.Show("Bill correction request for Reference Number: " + referenceNumber + " has been accepted.");

									string query = "SELECT CorrectionID, ReferenceNumber, Correction, CorrectionConfirmed FROM billCorrectedOptions";
									using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
									{
										DataTable dataTable = new DataTable();
										adapter.Fill(dataTable);

										CorrectionReqGridView.DataSource = dataTable;
									}
								}
								else
								{
									MessageBox.Show("Failed to update the bill correction request for Reference Number: " + referenceNumber);
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error occurred: " + ex.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a record from the grid view.");
			}
		}

		// Helper function to check if IsCorrectionRequested value is already 0
		private bool IsCorrectionRequested(int referenceNumber)
		{
			try
			{
				string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					string checkQuery = "SELECT IsCorrectionRequested FROM BillCorrection WHERE ReferenceNumber = @ReferenceNumber";
					using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
					{
						checkCommand.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
						object isRequestedObj = checkCommand.ExecuteScalar();

						if (isRequestedObj != null && isRequestedObj != DBNull.Value)
						{
							int isRequested = Convert.ToInt32(isRequestedObj);
							return isRequested == 0;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}

			return false;
		}

		private void AcceptReqBtn_MouseEnter(object sender, EventArgs e)
		{
			AcceptReqBtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void AcceptReqBtn_MouseLeave(object sender, EventArgs e)
		{
			AcceptReqBtn.FlatAppearance.BorderColor = Color.White;
		}
	}
}
