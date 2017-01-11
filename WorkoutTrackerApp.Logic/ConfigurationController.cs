using System;
using System.Configuration;

namespace WorkoutTrackerApp.Logic
{
	public static class ConfigurationController
	{
		/// <summary>
		/// Fetches the SQL Server connection string from the app.config.
		/// </summary>
		/// <returns>The SQL Server connection string.</returns>
		public static string RetrieveSqlConnectionString()
		{
			string result = null;

			try
			{
				result = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
			}
			catch (ConfigurationException configException)
			{
				DebugLogger.LogError(configException);
				throw configException;
			}
			catch (Exception exception)
			{
				DebugLogger.LogError(exception);
				throw exception;
			}

			return result;
		}
	}
}
