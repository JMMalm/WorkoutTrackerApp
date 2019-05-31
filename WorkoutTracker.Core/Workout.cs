using Dapper.Contrib.Extensions;
using System;

namespace WorkoutTracker.Core
{
	/// <summary>
	/// Represents a single workout event.
	/// </summary>
	/// <remarks>
	/// Use the "object initialization" syntax for instantiation.
	/// (https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions#new-operator)
	/// </remarks>
	[Table("Workouts")]
	public class Workout
	{
		[Key]
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string Location { get; set; }
		public DateTime LastModified { get; set; }
		public string LastModifiedBy { get; set; }
		public int UserId { get; set; }
		public string Notes { get; set; }
	}
}
