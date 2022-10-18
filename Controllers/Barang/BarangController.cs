using Koperasi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Koperasi.Helpers;
using Koperasi.Domain.Repositories;
using Koperasi.Models;

namespace Koperasi.Controllers;

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
}
