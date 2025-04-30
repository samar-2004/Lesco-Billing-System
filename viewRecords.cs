using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace BillingSystem
{
	public partial class viewRecords : Form
	{
		private string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
		public viewRecords()
		{
			InitializeComponent();
		}
		private void viewRecords_Load(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT * FROM CustomerTBL";
				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				DataTable customerTable = new DataTable();
				adapter.Fill(customerTable);
				CustomerGridView.DataSource = customerTable;
			}

			// Disable row selection and set the SortMode to Automatic for billingGridView
			billingGridView.AllowUserToAddRows = false;
			billingGridView.AllowUserToDeleteRows = false;
			foreach (DataGridViewColumn column in billingGridView.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.Automatic;
			}

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query_ = "SELECT * FROM MonthlyBilling";
				SqlDataAdapter adapter = new SqlDataAdapter(query_, connection);
				DataTable billingTable = new DataTable();
				adapter.Fill(billingTable);
				billingGridView.DataSource = billingTable;
			}

			// Handle the SelectionChanged event to clear the selection
			billingGridView.SelectionChanged += (s, eventArgs) =>
			{
				billingGridView.ClearSelection();
			};
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			AdminDashBoard adminDashBoard = new AdminDashBoard();
			adminDashBoard.Show();
		}

	}
}
