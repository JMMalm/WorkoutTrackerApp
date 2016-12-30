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

namespace WorkoutTrackerApp
{
	public partial class FormWorkoutTrackerMain : Form
	{
		public FormWorkoutTrackerMain()
		{
			InitializeComponent();
		}

		private void FormWorkoutTrackerMain_Shown(object sender, System.EventArgs e)
		{
			if (CanConnectToDatabase())
			{
				// Populate the DataGridView.
			}
		}

		private bool CanConnectToDatabase()
		{
			bool successfullyConnected = false;

			using (SqlConnection connection = new SqlConnection())
			{
				try
				{
					connection.ConnectionString = ConfigurationManager.ConnectionStrings["WorkoutTracker"].ConnectionString;
					connection.Open();
					successfullyConnected = true;
				}
				catch (ConfigurationException configException)
				{
					MessageBox.Show(configException.Message, "Configration Error", MessageBoxButtons.OK);
				}
				catch (SqlException sqlException)
				{
					MessageBox.Show(sqlException.Message, "Connection Error", MessageBoxButtons.OK);
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message, string.Format("{0} Error", e.GetType()), MessageBoxButtons.OK);
				}
			}

			return successfullyConnected;
		}

		private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SettingsConfigurationForm settingsConfig = new SettingsConfigurationForm();
			settingsConfig.Show();
		}
	}
}
