using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BillingSystem
{
	public partial class BillHistory : Form
	{

		string connection_ = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
		public BillHistory()
		{
			InitializeComponent();
		}

		private void Viewhistorybtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtReferenceNo.Text) || !int.TryParse(txtReferenceNo.Text, out int referenceNumber))
			{
				MessageBox.Show("Please enter a valid reference number.");
				return;
			}

			string query = "SELECT Month, YEAR(DateOfReading) AS Year, UnitsConsumed, BillAmount, PaymentStatus " +
						   "FROM MonthlyBilling " +
						   "WHERE ReferenceNumber = @ReferenceNumber " +
						   "ORDER BY Year DESC, Month DESC";

			using (SqlConnection connection = new SqlConnection(connection_))
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
				DataTable dataTable = new DataTable();

				try
				{
					connection.Open();

					using (SqlDataAdapter adapter = new SqlDataAdapter(command))
					{
						adapter.Fill(dataTable);
					}

					if (dataTable.Rows.Count == 0)
					{
						MessageBox.Show("No billing history found for the provided reference number.");
					}
					else
					{
						historyGridView.DataSource = dataTable;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}
		private void backbtn_Click(object sender, EventArgs e)
		{
			CustomerDashboard customerDashboard = new CustomerDashboard();
			customerDashboard.Show();
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

		private void Viewhistorybtn_MouseEnter(object sender, EventArgs e)
		{
			Viewhistorybtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void Viewhistorybtn_MouseLeave(object sender, EventArgs e)
		{
			Viewhistorybtn.FlatAppearance.BorderColor = Color.White;
		}
	}
}
