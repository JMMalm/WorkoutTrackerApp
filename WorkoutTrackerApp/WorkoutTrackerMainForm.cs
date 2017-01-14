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
using WorkoutTrackerApp.Logic;

namespace WorkoutTrackerApp
{
	/// <summary>
	/// This is the main form for the Workout Tracker App. From here, all
	/// other functionality can be accessed.
	/// </summary>
	public partial class FormWorkoutTrackerMain : Form
	{
		/// <summary>
		/// Initializes the main form.
		/// </summary>
		public FormWorkoutTrackerMain()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Upon loading the main form, begins to populate the data grid view
		/// with Workout data in the main form.
		/// </summary>
		/// <param name="sender">The calling object.</param>
		/// <param name="e">Event data associated with this call.</param>
		private void FormWorkoutTrackerMain_Shown(object sender, System.EventArgs e)
		{
			PopulateDataGridViewWithWorkoutData();
		}

		/// <summary>
		/// Queries the database for the results necessary to populate the main
		/// form's data grid view with Workout data.
		/// </summary>
		private void PopulateDataGridViewWithWorkoutData()
		{
			WorkoutRepository workoutRepository = new WorkoutRepository();
			// TODO: Create ".Get()" overload to populate table with a range of rows.
			Workout results = workoutRepository.Get(1);

			DataTable workoutDataTable = new DataTable();
			workoutDataTable.Rows.Add(results.ToRow(workoutDataTable));
			DataGridViewWorkouts.DataSource = workoutDataTable;
		}

		private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SettingsConfigurationForm settingsConfig = new SettingsConfigurationForm();
			settingsConfig.Show();
		}
	}
}
