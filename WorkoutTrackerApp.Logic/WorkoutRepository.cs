using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WorkoutTrackerApp.Logic
{
	public class WorkoutRepository
	{
		public WorkoutRepository() { }

		public void Save(Workout workout)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves a single Workout from the database.
		/// </summary>
		/// <param name="id">Id of the Workout to retrieve.</param>
		/// <returns>If Id exists, a Workout object populated with values.</returns>
		public Workout Get(int id)
		{
			SqlCommand command = PrepareSqlQuery(Properties.Resources.WorkoutsGetSingle);
			command.Parameters.AddWithValue("@Id", id);
			return RunQueryGetWorkout(command);
		}

		public List<Workout> Get(int minId, int maxId)
		{
			SqlCommand command = PrepareSqlQuery(Properties.Resources.WorkoutsGetMultiple);
			command.Parameters.AddWithValue("@minId", minId);
			command.Parameters.AddWithValue("@maxId", maxId);
			return RunQueryGetWorkouts(command);
		}

		private static SqlCommand PrepareSqlQuery(string sqlQueryResource)
		{
			SqlConnection connection = new SqlConnection(ConfigurationController.RetrieveSqlConnectionString());
			SqlCommand command = new SqlCommand(sqlQueryResource, connection);
			return command;
		}

		public void Delete(Workout workout)
		{
			throw new NotImplementedException();
		}

		public Workout RunQueryGetWorkout(SqlCommand sqlQuery)
		{
			List<Workout> queryResults = RunQueryGetWorkouts(sqlQuery);
			if (queryResults != null && queryResults.Count > 0)
				return queryResults[0];
			return null;
		}

		public List<Workout> RunQueryGetWorkouts(SqlCommand sqlQuery)
		{
			List<Workout> result = new List<Workout>();
			using (sqlQuery.Connection)
			using (sqlQuery)
			{
				try
				{
					sqlQuery.Connection.Open();
					SqlDataReader queryResult = sqlQuery.ExecuteReader();

					if (queryResult.HasRows)
					{
						while (queryResult.Read())
						{
							result.Add(new Workout(
								Convert.ToInt32(queryResult["Id"]),
								Convert.ToDateTime(queryResult["StartTime"]),
								Convert.ToDateTime(queryResult["EndTime"]),
								queryResult["Location"].ToString()));
						}
					}
				}
				catch (SqlException sqlException)
				{
					DebugLogger.LogError(sqlException);
				}
				catch (Exception exception)
				{
					DebugLogger.LogError(exception);
				}
				sqlQuery.Connection.Close();
			}

			return result;
		}
	}
}
