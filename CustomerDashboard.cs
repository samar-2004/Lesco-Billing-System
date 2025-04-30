using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
	public partial class CustomerDashboard : Form
	{
		public CustomerDashboard()
		{
			InitializeComponent();
		}

		private void viewRecordsbtn_Click(object sender, EventArgs e)
		{
			currentBill currentBill = new currentBill();
			currentBill.Show();
		}

		private void viewCUrrentBillbtn_MouseEnter(object sender, EventArgs e)
		{
			viewCUrrentBillbtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void viewCUrrentBillbtn_MouseLeave(object sender, EventArgs e)
		{
			viewCUrrentBillbtn.FlatAppearance.BorderColor = Color.White;

		}

		private void viewBillHistory_MouseEnter(object sender, EventArgs e)
		{
			viewBillHistory.FlatAppearance.BorderColor = Color.Violet;
		}

		private void viewBillHistory_MouseLeave(object sender, EventArgs e)
		{
			viewBillHistory.FlatAppearance.BorderColor = Color.White;
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			mainform mainform = new mainform();
			mainform.Show();
		}

		private void viewBillHistory_Click(object sender, EventArgs e)
		{
			BillHistory billHistory = new BillHistory();
			billHistory.Show();
		}
	}
}
