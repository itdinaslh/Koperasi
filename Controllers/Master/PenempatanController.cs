using Koperasi.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Koperasi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Koperasi.Helpers;

namespace Koperasi.Controllers;

public class PenempatanController : Controller
{
    private readonly ITugasTempat repo;

    public PenempatanController(ITugasTempat repo)
    {
        this.repo = repo;
    }

    [HttpGet("/master/penempatan")]
    public IActionResult Index()
    {
        return View("~/Views/Master/Penempatan/Index.cshtml");
    }

    [HttpGet("/master/penempatan/create")]
    public IActionResult Create()
    {
        return PartialView("~/Views/Master/Penempatan/AddEdit.cshtml", new Penempatan());
    }

    [HttpGet("/master/penempatan/edit")]
    public async Task<IActionResult> Edit(int id)
    {
        Penempatan? data = await repo.Penempatans.FirstOrDefaultAsync(p => p.PenempatanId == id);

        if (data is not null)
        {
            return PartialView("~/Views/Master/Penempatan/AddEdit.cshtml", data);
        }

        return NotFound();
    }

    [HttpPost("/master/penempatan/save")]
    public async Task<IActionResult> SavePenempatan(Penempatan model)
    {
        if (ModelState.IsValid)
        {
            await repo.SavePenempatan(model);

            return Json(Result.Success());
        }

        return PartialView("~/Views/Master/Penempatan/AddEdit.cshtml", model);
    }
}
