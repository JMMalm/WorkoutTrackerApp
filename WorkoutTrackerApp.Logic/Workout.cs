using System;
using System.Data;

namespace WorkoutTrackerApp.Logic
{
	/// <summary>
	/// Represents a single Workout session.
	/// </summary>
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

		/// <summary>
		/// Runs custom checks on the Workout's properties to ensure
		/// it is ready for data operations.
		/// </summary>
		/// <returns>An exception if an undesireable property condition is found.</returns>
		/// <remarks>
		/// This method will typically be called before inserting records into the database.
		/// </remarks>
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

		/// <summary>
		/// Checks Workout ID for invalid values.
		/// </summary>
		public void ValidateId()
		{
			if (Id < 0)
			{
				throw new ArgumentOutOfRangeException("Id", "The ID cannot be less than zero.");
			}
			if (Id >= 2147483647)
			{
				// Any larger values won't fit in the table's ID column.
				throw new ArgumentOutOfRangeException("Id", "The ID cannot be greater than 2,147,483,647");
			}
		}

		/// <summary>
		/// Checks the Workout Location for invalid values.
		/// </summary>
		public void ValidateLocation()
		{
			if (string.IsNullOrEmpty(Location) || string.IsNullOrWhiteSpace(Location))
			{
				throw new ArgumentException("The Location cannot be solely whitespace or empty.");
			}
			if (Location.Length > 50)
			{
				throw new ArgumentOutOfRangeException("The Location cannot exceed 50 characters.");
			}
		}

		/// <summary>
		/// Generates a DataRow object using this Workout's properties.
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
			foreach (var type in this.GetType().GetProperties())
			{
				if (!sourceTable.Columns.Contains(type.Name.ToString()))
					sourceTable.Columns.Add(type.Name.ToString(), type.PropertyType);
				workoutRow[type.Name.ToString()] = type.GetValue(this);
			}

			return workoutRow;
		}
	}
}
