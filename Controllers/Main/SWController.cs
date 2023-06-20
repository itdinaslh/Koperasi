using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Koperasi.Controllers;


public class SWController : Controller
{
    [HttpGet("/simpanan_wajib/list")]
    [Authorize(Roles = "SysAdmin, KoperasiAdmin")]
    public IActionResult List()
    {
        return View("~/Views/Main/SW/List.cshtml");
    }

	[HttpGet("/simpanan_wajib/create")]
	public IActionResult Create()
	{
		return PartialView("~/Views/Main/SW/AddEdit.cshtml");
	}
}
