using Koperasi.Domain.Entities;
using Koperasi.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Koperasi.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace Koperasi.Controllers;

[Authorize(Roles = "SysAdmin, KoperasiAdmin")]
public class PenugasanController : Controller
{
    private readonly ITugasTempat repo;

    public PenugasanController(ITugasTempat repo)
    {
        this.repo = repo;
    }

    [HttpGet("/master/penugasan")]
    public ViewResult Index()
    {
        return View("~/Views/Master/Penugasan/Index.cshtml");
    }

    [HttpGet("/master/penugasan/create")]
    public IActionResult Create()
    {
        return PartialView("~/Views/Master/Penugasan/AddEdit.cshtml", new Penugasan());
    }

    [HttpGet("/master/penugasan/edit")]
    public async Task<IActionResult> Edit(int id)
    {
        Penugasan? data = await repo.Penugasans.FirstOrDefaultAsync(p => p.PenugasanID == id);

        if (data is not null)
        {
            return PartialView("~/Views/Master/Penugasan/AddEdit.cshtml", data);
        }

        return NotFound();
    }

    [HttpPost("/master/penugasan/save")]
    public async Task<IActionResult> SavePenugasan(Penugasan model)
    {
        if (ModelState.IsValid)
        {
            await repo.SavePenugasan(model);

            return Json(Result.Success());
        }

        return PartialView("~/Views/Master/Penugasan/AddEdit.cshtml", model);
    }
}
