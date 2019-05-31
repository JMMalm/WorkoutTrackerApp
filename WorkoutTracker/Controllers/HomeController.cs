using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Core;
using WorkoutTracker.Models;

namespace WorkoutTracker.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View(GetDummyWorkouts());
		}

		public IActionResult Details(int id)
		{
			return View(GetDummyWorkouts().Where(w => w.Id == id).FirstOrDefault());
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		/// <summary>
		/// Returns a collection of dummy, in-memory workout data.
		/// </summary>
		/// <remarks>
		/// This is temporary until the database gets set up.
		/// </remarks>
		private IEnumerable<Workout> GetDummyWorkouts()
		{
			return new List<Workout>
			{
				new Workout { Id = 0, Date = DateTime.Now.AddDays(-5), LastModified = DateTime.Now, LastModifiedBy = "jmalm", Location = "Anytime Fitness", UserId = 0 },
				new Workout { Id = 1, Date = DateTime.Now.AddDays(-3), LastModified = DateTime.Now, LastModifiedBy = "jmalm", Location = "Anytime Fitness", UserId = 0 },
				new Workout { Id = 2, Date = DateTime.Now.AddDays(-1), LastModified = DateTime.Now, LastModifiedBy = "jmalm", Location = "Anytime Fitness", UserId = 0 }
			};
		}
	}
}
