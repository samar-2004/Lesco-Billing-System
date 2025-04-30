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
	public partial class mainform : Form
	{
		public mainform()
		{
			InitializeComponent();
		}

		private void adminbtn_Click(object sender, EventArgs e)
		{
			AdminLogIn adminLoginForm = new AdminLogIn();
			adminLoginForm.Show();
		}

		private void customerbtn_Click(object sender, EventArgs e)
		{
			CustomerDashboard customerDashboard = new CustomerDashboard();	
			customerDashboard.Show();	
		}
	}
}
