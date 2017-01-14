using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTrackerApp.Logic
{
	public class Workout
	{
		// Required in the database. (i.e. NOT NULLABLE)
		public int Id { get; private set; }
		public DateTime StartTime { get; private set; }
		public DateTime EndTime { get; private set; }
		public string Location { get; private set; }

		// Optional in the database.
		public string WorkoutEmphasis { get; private set; }
		public int WorkoutRoutineId { get; private set; }
		public int Rating { get; private set; }
		public int BodyWeight {get; private set;}
		public int BodyMassIndex { get; private set; }
		public string Notes { get; private set; }

		/// <summary>
		/// Creates a new Workout object.
		/// </summary>
		/// <param name="id">The Id of the workout session.</param>
		/// <param name="startTime">The start time of the workout session.</param>
		/// <param name="endTime">The end time of the workout session.</param>
		/// <param name="location">The location of the workout session.</param>
		/// <remarks>
		/// This constructor satisfies the minimum requirements necessary for database operations.
		/// </remarks>
		public Workout(int id, DateTime startTime, DateTime endTime, string location)
		{
			Id = id;
			StartTime = startTime;
			EndTime = endTime;
			Location = location;
		}

		public Exception Validate()
		{
			Exception validationResult = null;

			try
			{
				ValidateId();
				ValidateLocation();
			}
			catch (Exception e)
			{
				validationResult = e;
			}
			return validationResult;
		}

		public Exception ValidateId()
		{
			if (Id < 0) { throw new ArgumentOutOfRangeException("Id", "The ID cannot be less than zero."); }
			// Any larger values won't fit in the database column.
			if (Id >= 2147483647) { throw new ArgumentOutOfRangeException("Id", "The ID cannot be greater than 2,147,483,647"); }
			return null;
		}

		public Exception ValidateLocation()
		{
			if (string.IsNullOrEmpty(Location) || string.IsNullOrWhiteSpace(Location))
			{
				throw new ArgumentException("The Location cannot be solely whitespace or empty.");
			}
			if (Location.Length > 50)
			{
				throw new ArgumentOutOfRangeException("The Location cannot exceed 50 characters.");
			}
			return null;
		}

		/// <summary>
		/// Converts a Workout object into a DataRow object.
		/// </summary>
		/// <param name="sourceTable">The calling table that needs Workout data to be added to it.</param>
		/// <returns>A new DataRow of Workout data.</returns>
		/// <remarks>
		/// The workflow for calling this method is that we have a Workout object
		/// and a DataTable that will be used to populate a DataGridView.
		/// </remarks>
		public DataRow ToRow(DataTable sourceTable)
		{
			DataRow workoutRow = sourceTable.NewRow();
			// This would be much easier using Entity Framework, yes, but as you can see
			// this is a learning opportunity into reflection.
			foreach (var type in this.GetType().GetProperties())
			{
				// TODO: This sourceTable has a "code smell". Table construction should not
				// be dependent upon the Workout class.
				sourceTable.Columns.Add(type.Name.ToString(), type.PropertyType);
				workoutRow[type.Name.ToString()] = type.GetValue(this);
			}

			return workoutRow;
		}
	}
}
