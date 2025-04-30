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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace BillingSystem
{
	public partial class billCorrectOptions : Form
	{
		string connection_ = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
		private int referenceNumber;
		public billCorrectOptions(string refernceNumber)
		{
			InitializeComponent();
			this.referenceNumber = Convert.ToInt32(refernceNumber);
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			currentBill currentBill = new currentBill();
			currentBill.Show();
		}

		private void btnBillCorrection_Click(object sender, EventArgs e)
		{
			RadioButton selectedRadioButton = radioGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

			if (selectedRadioButton != null)
			{
				string correction = selectedRadioButton.Text;

				string connectionString = connection_;

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					string checkQuery = "SELECT TOP 1 CorrectionID FROM billCorrectedOptions " +
										"WHERE ReferenceNumber = @ReferenceNumber " +
										"AND Correction = @Correction " +
										"AND CorrectionConfirmed = 1";

					using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
					{
						checkCommand.Parameters.AddWithValue("@ReferenceNumber", referenceNumber); 
						checkCommand.Parameters.AddWithValue("@Correction", correction);

						object existingCorrectionID = checkCommand.ExecuteScalar();

						if (existingCorrectionID != null)
						{
							MessageBox.Show($"Your bill correction request for '{correction}' is already accepted, and the correction has been made.");

							int correctionID = Convert.ToInt32(existingCorrectionID);
							string deleteQuery = "DELETE FROM billCorrectedOptions WHERE CorrectionID = @CorrectionID";

							using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
							{
								deleteCommand.Parameters.AddWithValue("@CorrectionID", correctionID);
								deleteCommand.ExecuteNonQuery();
							}
						}
						else
						{
							string insertQuery = "INSERT INTO billCorrectedOptions (ReferenceNumber, Correction, CorrectionConfirmed) " +
												"VALUES (@ReferenceNumber, @Correction, @CorrectionConfirmed)";

							using (SqlCommand command = new SqlCommand(insertQuery, connection))
							{
								command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber); 
								command.Parameters.AddWithValue("@Correction", correction);
								command.Parameters.AddWithValue("@CorrectionConfirmed", false);

								command.ExecuteNonQuery();
							}

							MessageBox.Show("Correction request has been submitted successfully.");
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a correction option.");
			}
		}

	}
}
