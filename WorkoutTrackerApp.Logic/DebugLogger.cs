using System;
using System.Diagnostics;

namespace WorkoutTrackerApp.Logic
{
	/// <summary>
	/// Logs runtime errors for the WorkoutTrackerApp.
	/// </summary>
	public static class DebugLogger
	{
		/// <summary>
		/// Writes exception data (message, stack trace) to the app's log file.
		/// </summary>
		/// <param name="ex">The exception to be logged.</param>
		public static void LogError(Exception ex)
		{
			Trace.WriteLine(FormatErrorMessage(ex));
		}

		/// <summary>
		/// Cleanly formats an exception's message and stack trace, along with a timestamp.
		/// </summary>
		/// <param name="ex">The exception being logged.</param>
		/// <returns>Formatted string of timestamp and exception data.</returns>
		private static string FormatErrorMessage(Exception ex)
		{
			return string.Format("{0}: {1}{2}{3}", DateTime.Now, ex.Message, Environment.NewLine, ex.StackTrace);
		}
	}
}
