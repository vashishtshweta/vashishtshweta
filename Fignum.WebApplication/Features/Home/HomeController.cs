using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Core.Interfaces.Services.Filter;
using Fignum.WebApplication.Features.Home.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Fignum.WebApplication.Features.Home
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IFilterService _filter;

		public HomeController(ILogger<HomeController> logger,
			IFilterService filter)
		{
			_logger = logger;
			_filter = filter;
		}

		public IActionResult Index()
		{
			IndexViewModel model = new IndexViewModel();
			return View(model);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(IndexViewModel model)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return BadRequest(ModelState);
				}

				ModelState.Remove("PassedInValue");
				var primeNumberList = _filter.FilterPrimeNumberfromString(model.PassedInValue);
				var result = _filter.RemovePrimeNumberFromString(model.PassedInValue);
				var sortedresult = _filter.SortData(result);
				model.OriginalInput = model.PassedInValue;
				model.PassedInValue = sortedresult;
				model.PrimeNumber = primeNumberList;
				return View(model);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, string.Format(""));
				return StatusCode(StatusCodes.Status500InternalServerError, "Error while loading data. Please try again");
			}
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
