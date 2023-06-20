using Koperasi.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Koperasi.Controllers;


public class PinjamanController : Controller
{
    [HttpGet("/pinjaman/list")]
    [Authorize(Roles = "SysAdmin, KoperasiAdmin")]
    public IActionResult List()
    {
        return View("~/Views/Main/Pinjaman/List.cshtml");
    }

	[HttpGet("/pinjaman/create")]
	public IActionResult Create()
	{
		return PartialView("~/Views/Main/Pinjaman/AddEdit.cshtml");
	}

	[HttpGet("/pinjaman/bayar")]
	public IActionResult Pay()
	{
		return PartialView("~/Views/Main/Pinjaman/Bayar.cshtml");
	}

	[HttpGet("/pinjaman/details")]
	public IActionResult Details()
	{
		return View("~/Views/Main/Pinjaman/Details.cshtml");
	}
}
