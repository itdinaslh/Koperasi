using Koperasi.Domain.Entities;
using Koperasi.Domain.Repositories;
using Koperasi.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Koperasi.Controllers;

public class GolonganController : Controller
{
	private readonly IGolongan repo;

	public GolonganController(IGolongan repo)
	{
		this.repo = repo;
	}

	[HttpGet("/master/golongan")]
	public IActionResult Index()
	{
		return View("~/Views/Master/Golongan/Index.cshtml");
	}

	[HttpGet("/master/golongan/create")]
	public IActionResult Create()
	{
		return PartialView("~/Views/Master/Golongan/AddEdit.cshtml", new Golongan());
	}

	[HttpGet("/master/golongan/edit")]
	public async Task<IActionResult> Edit(int id)
	{
		Golongan? data = await repo.Golongans.FirstOrDefaultAsync(i => i.GolonganId == id);

		if (data is not null)
		{
			return PartialView("/Views/Master/Golongan/AddEdit.cshtml", data);
		}

		return NotFound();
	}

	[HttpPost("/master/golongan/save")]
	public async Task<IActionResult> SaveGolongan(Golongan golongan)
	{
		if (ModelState.IsValid)
		{
			await repo.SaveDataAsync(golongan);

			return Json(Result.Success());
		}

		return PartialView("/Views/Master/Golongan/AddEdit.cshtml", golongan);
	}
}
