using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Koperasi.Controllers.Master
{
	public class ProfitController : Controller
	{
		[HttpGet("/master/profit")]
		[Authorize(Roles = "SysAdmin, KoperasiAdmin")]
		public IActionResult Index()
		{
			return View("~/Views/Master/Profit/Index.cshtml");
		}

		[HttpGet("/master/profit/create")]
		public IActionResult Create()
		{
			return PartialView("~/Views/Master/Profit/AddEdit.cshtml");
		}
	}
}
