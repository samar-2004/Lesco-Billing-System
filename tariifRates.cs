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
	public partial class tariifRates : Form
	{
		public tariifRates()
		{
			InitializeComponent();
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			currentBill currentBill = new currentBill();
			currentBill.Show();
		}
	}
}
