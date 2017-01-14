using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			SqlConnection connection = new SqlConnection(ConfigurationController.RetrieveSqlConnectionString());
			SqlCommand command = new SqlCommand(Properties.Resources.WorkoutsGetSingle, connection);
			command.Parameters.AddWithValue("@Id", id);
			return RunQuery(command);
		}

		public Workout[] GetRange(int start, int end)
		{
			throw new NotImplementedException();
		}

		public void Delete(Workout workout)
		{
			throw new NotImplementedException();
		}

		// TODO: Rename method; name does not imply the return object.
		public Workout RunQuery(SqlCommand sqlQuery)
		{
			Workout result = null;
			using (sqlQuery.Connection)
			using (sqlQuery)
			{
				try
				{
					sqlQuery.Connection.Open();
					SqlDataReader queryResult = sqlQuery.ExecuteReader();

					if (queryResult.HasRows)
					{
						// TODO: Make a distinction between single/multiple result queries.
						// This will repeatedly overwrite a single workout in the latter case.
						while (queryResult.Read())
						{
							result = new Workout(
								Convert.ToInt32(queryResult["Id"]),
								Convert.ToDateTime(queryResult["StartTime"]),
								Convert.ToDateTime(queryResult["EndTime"]),
								queryResult["Location"].ToString());
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
