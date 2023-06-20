using Koperasi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Koperasi.Helpers;
using Koperasi.Domain.Repositories;
using Koperasi.Models;
using Microsoft.AspNetCore.Authorization;

namespace Koperasi.Controllers;

[Authorize]
public class BarangController : Controller
{
    private readonly IBarang repo;

    public BarangController(IBarang repo)
    {
        this.repo = repo;
    }

    [HttpGet("/master/barang/jenis")]
    public IActionResult JenisIndex()
    {
        return View("~/Views/Barang/Jenis/Index.cshtml");
    }

    [HttpGet("/master/barang/merk")]
    public IActionResult MerkIndex()
    {
        return View("~/Views/Barang/Merk/Index.cshtml");
    }

	[HttpGet("/master/barang/tipe")]
	public IActionResult TipeIndex()
	{
		return View("~/Views/Barang/Tipe/Index.cshtml");
	}

	[HttpGet("/master/barang/jenis/create")]
    public IActionResult CreateJenis()
    {
        return PartialView("~/Views/Barang/Jenis/AddEdit.cshtml", new JenisBarang());
    }

    [HttpGet("/master/barang/merk/create")]
    public IActionResult CreateMerk()
    {
        return PartialView("~/Views/Barang/Merk/AddEdit.cshtml", new MerkVM {
            MerkBarang = new MerkBarang(),
            NamaJenis = String.Empty
        });
    }
	[HttpGet("/master/barang/tipe/create")]
	public IActionResult CreateTipe()
	{
		return PartialView("~/Views/Barang/Tipe/AddEdit.cshtml", new TipeVM
		{
			TipeBarang = new TipeBarang(),
			NamaMerk = String.Empty
		});
	}

	[HttpPost("/master/barang/jenis/save")]
    public async Task<IActionResult> SaveJenisBarang(JenisBarang model)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveJenisBarang(model);

            return Json(Result.Success());
        }

        return PartialView("~/Views/Barang/Jenis/AddEdit.cshtml", model);
    }

    [HttpPost("/master/barang/merk/save")]
    public async Task<IActionResult> SaveMerkBarang(MerkVM model)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveMerkBarang(model.MerkBarang);

            return Json(Result.Success());
        }

        return PartialView("~/Views/Barang/Jenis/AddEdit.cshtml", model);
    }

    [HttpPost("/master/barang/tipe/save")]
    public async Task<IActionResult> SaveTipeBarang(TipeVM model)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveTipeBarang(model.TipeBarang);

            return Json(Result.Success());
        }

        return PartialView("~/Views/Barang/Jenis/AddEdit.cshtml", model);
    }
}
