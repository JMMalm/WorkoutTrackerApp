using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutTrackerApp.Logic;

namespace WorkoutTrackerAppTests
{
	[TestClass]
	public class WorkoutTests
	{
		[TestMethod]
		public void ValidateId_ValidValue_Success()
		{
			// Arrange
			Workout workout = new Workout(1, DateTime.Now, DateTime.Now.AddHours(1.0), "Minneapolis");

			// Act
			workout.ValidateId();

			// Assert
			// No exception expected.
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ValidateId_MinValue_Exception()
		{
			// Arrange
			Workout workout = new Workout(-1, DateTime.Now, DateTime.Now.AddHours(1.0), "Minneapolis");

			// Act
			workout.ValidateId();

			// Assert
			// Expected exception
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ValidateId_MaxValue_Exception()
		{
			// Arrange
			Workout workout = new Workout(2147483647, DateTime.Now, DateTime.Now.AddHours(1.0), "Minneapolis");

			// Act
			workout.ValidateId();

			// Assert
			// Expected exception
		}

		[TestMethod]
		public void ValidateLocation_GoodValue_Success()
		{
			// Arrange
			Workout workout = new Workout(1, DateTime.Now, DateTime.Now.AddHours(1.0), "Minneapolis");

			// Act
			workout.ValidateLocation();

			// Assert
			// No exception expected.
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void ValidateLocation_NullValue_Exception()
		{
			// Arrange
			Workout workout = new Workout(1, DateTime.Now, DateTime.Now.AddHours(1.0), null);

			// Act
			workout.ValidateLocation();

			// Assert
			// Expected exception
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void ValidateLocation_EmptyValue_Exception()
		{
			// Arrange
			Workout workout = new Workout(1, DateTime.Now, DateTime.Now.AddHours(1.0), "");

			// Act
			workout.ValidateLocation();

			// Assert
			// Expected exception
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ValidateLocation_TooLongValue_Exception()
		{
			// Arrange
			Workout workout = new Workout(1, DateTime.Now, DateTime.Now.AddHours(1.0), "Minneapolis-Washington-Avenue-Between-First-And-Second-Avenues");

			// Act
			workout.ValidateLocation();

			// Assert
			// Expected exception
		}

		[TestMethod]
		public void ToRow_ValidValues_Success()
		{
			// Arrange
			Workout workout = new Workout(1, DateTime.Now, DateTime.Now.AddHours(1.0), "Minneapolis");

			// Act
			var actual = workout.ToRow(new DataTable());

			// Assert
			Assert.AreEqual(workout.Id, actual["Id"]);
			Assert.AreEqual(workout.StartTime, actual["StartTime"]);
			Assert.AreEqual(workout.EndTime, actual["EndTime"]);
			Assert.AreEqual(workout.Location, actual["Location"]);
		}
	}
}
