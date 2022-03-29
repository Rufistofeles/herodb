using ConsumeAPI.APIService;
using ConsumeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsumeAPI.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IAPIService _apiService;

		public HomeController(ILogger<HomeController> logger, IAPIService apiService)
		{
			_logger = logger;
			_apiService = apiService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(string Name)
		{
			var result = await _apiService.SearchByName(Name);

			ViewBag.resultsByName = result;

			return View();
		}

		[HttpPost]
		public async Task<JsonResult> SearchById(string Id)
		{
			var result = await _apiService.SearchById(Id);

			if(result.Response != "success")
			{
				return Json(null);				
			}
			else
			{
				return Json(result);
			}
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
	}
}