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
		private enum DefaultIdValues
		{
			defaultMin = 1,
			defaultMax = 10
		}

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
			PopulateDataGridViewWithWorkoutData((int)DefaultIdValues.defaultMin, (int)DefaultIdValues.defaultMax);
		}

		/// <summary>
		/// Populates the main form's data grid view with Workout data.
		/// </summary>
		private void PopulateDataGridViewWithWorkoutData(int id)
		{
			Workout results = new WorkoutRepository().Get(id);
			DataTable workoutDataTable = new DataTable();
			workoutDataTable.Rows.Add(results.ToRow(workoutDataTable));
			DataGridViewWorkouts.DataSource = workoutDataTable;
		}

		/// <summary>
		/// Populates the main form's data grid view with a range of Workout data.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		private void PopulateDataGridViewWithWorkoutData(int start, int end)
		{
			List<Workout> results = new WorkoutRepository().Get(start, end);
			DataTable workoutDataTable = new DataTable();

			foreach (Workout workout in results)
			{
				workoutDataTable.Rows.Add(workout.ToRow(workoutDataTable));
			}

			DataGridViewWorkouts.DataSource = workoutDataTable;
		}
	}
}
