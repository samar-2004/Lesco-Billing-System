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
	public partial class AdminDashBoard : Form
	{
		public AdminDashBoard()
		{
			InitializeComponent();
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			AdminLogIn adminLogIn = new AdminLogIn();
			adminLogIn.Show();
		}

		private void addnewCustomerbtn_MouseEnter(object sender, EventArgs e)
		{
			addnewCustomerbtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void addnewCustomerbtn_MouseLeave(object sender, EventArgs e)
		{
			addnewCustomerbtn.FlatAppearance.BorderColor = Color.Black;
		}

		private void viewRecordsbtn_MouseEnter(object sender, EventArgs e)
		{
			viewRecordsbtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void viewRecordsbtn_MouseLeave(object sender, EventArgs e)
		{
			viewRecordsbtn.FlatAppearance.BorderColor = Color.Black;
		}

		private void viewRecordsbtn_Click(object sender, EventArgs e)
		{
			viewRecords viewrecords = new viewRecords();
			viewrecords.Show();
		}

		private void addnewCustomerbtn_Click(object sender, EventArgs e)
		{
			AddNewCustomer addNewCustomer = new AddNewCustomer();	
			addNewCustomer.Show();
		}

		private void UpdateReadingBTN_MouseEnter(object sender, EventArgs e)
		{
			UpdateReadingBTN.FlatAppearance.BorderColor = Color.Violet;
		}

		private void UpdateReadingBTN_MouseLeave(object sender, EventArgs e)
		{
			UpdateReadingBTN.FlatAppearance.BorderColor = Color.Black;
		}

		private void UpdateReadingBTN_Click(object sender, EventArgs e)
		{
			updateMeterReading updateMeterReading = new updateMeterReading();
			updateMeterReading.Show();	
		}

		private void CorrectionRequestsBtn_MouseEnter(object sender, EventArgs e)
		{
			CorrectionRequestsBtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void CorrectionRequestsBtn_MouseLeave(object sender, EventArgs e)
		{
			CorrectionRequestsBtn.FlatAppearance.BorderColor = Color.Black;
		}

		private void CorrectionRequestsBtn_Click(object sender, EventArgs e)
		{
			billCorrection billCorrection = new billCorrection();
			billCorrection.Show();	
		}

		private void billPaymentbtn_MouseEnter(object sender, EventArgs e)
		{
			billPaymentbtn.FlatAppearance.BorderColor = Color.Violet;
		}

		private void billPaymentbtn_MouseLeave(object sender, EventArgs e)
		{
			billPaymentbtn.FlatAppearance.BorderColor = Color.Black;
		}

		private void billPaymentbtn_Click(object sender, EventArgs e)
		{
			payment payment= new payment();	
			payment.Show();
		}
	}
}
