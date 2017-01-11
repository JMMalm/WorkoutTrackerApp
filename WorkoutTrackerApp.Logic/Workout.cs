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
		// Required in the database.
		public int Id { get; private set; }
		public DateTime Date { get; private set; }
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

		public Workout() { }

		public Workout(int id, DateTime startTime, DateTime endTime, string location)
		{
			Id = id;
			Date = startTime.Date;
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

		public DataRow ToRow()
		{
			// TODO:
			foreach (var type in this.GetType().GetProperties())
			{
				throw new NotImplementedException();
				// Build a datarow object to easily transplant into a DataGridView.
			}

			return null;
		}
	}
}
