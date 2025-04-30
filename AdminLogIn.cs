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
	public partial class AdminLogIn : Form
	{
		public AdminLogIn()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			mainform mainf = new mainform();	
			mainf.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string username = txtusername.Text;
			string password = txtpassword.Text;

			usernameError.Enabled = false;
			passwordErro.Enabled = false;

			if (username.Equals("Admin", StringComparison.OrdinalIgnoreCase))
			{

			}
			else
			{
				usernameError.Enabled = true;
			}

			if (password.Equals("Admin", StringComparison.OrdinalIgnoreCase))
			{
			}
			else
			{
				passwordErro.Enabled = true;
			}

			if (username.Equals("Admin", StringComparison.OrdinalIgnoreCase) && password.Equals("Admin", StringComparison.OrdinalIgnoreCase))
			{
				AdminDashBoard adminDash = new AdminDashBoard();
				adminDash.Show();
			}
		}

		private void button2_MouseEnter(object sender, EventArgs e)
		{
			button2.FlatAppearance.BorderColor = Color.Violet;
		}

		private void button2_MouseLeave(object sender, EventArgs e)
		{
			button2.FlatAppearance.BorderColor = Color.White;
		}
	}
}
