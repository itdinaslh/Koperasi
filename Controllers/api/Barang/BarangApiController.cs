using Koperasi.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Koperasi.Controllers.api;

[Route("api/[controller]")]
[ApiController]
public class BarangApiController : ControllerBase
{
    private readonly IBarang repo;

    public BarangApiController(IBarang repo)
    {
        this.repo = repo;
    }

    [HttpPost("/api/barang/jenis")]
    public async Task<IActionResult> JenisBarangTable()
    {
        var draw = Request.Form["draw"].FirstOrDefault();
        var start = Request.Form["start"].FirstOrDefault();
        var length = Request.Form["length"].FirstOrDefault();
        var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
        var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
        var searchValue = Request.Form["search[value]"].FirstOrDefault();
        int pageSize = length != null ? Convert.ToInt32(length) : 0;
        int skip = start != null ? Convert.ToInt32(start) : 0;
        int recordsTotal = 0;

        var init = repo.JenisBarangs;

        if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
        {
            init = init.OrderBy(sortColumn + " " + sortColumnDirection);
        }

        if (!string.IsNullOrEmpty(searchValue))
        {
            init = init.Where(a => a.NamaJenis.ToLower().Contains(searchValue.ToLower()));
        }

        recordsTotal = init.Count();

        var result = await init.Skip(skip).Take(pageSize).ToListAsync();

        var jsonData = new { draw, recordsFiltered = recordsTotal, recordsTotal, data = result };

        return Ok(jsonData);
    }

    [HttpPost("/api/barang/merk")]
    public async Task<IActionResult> MerkBarangTable()
    {
        var draw = Request.Form["draw"].FirstOrDefault();
        var start = Request.Form["start"].FirstOrDefault();
        var length = Request.Form["length"].FirstOrDefault();
        var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
        var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
        var searchValue = Request.Form["search[value]"].FirstOrDefault();
        int pageSize = length != null ? Convert.ToInt32(length) : 0;
        int skip = start != null ? Convert.ToInt32(start) : 0;
        int recordsTotal = 0;

        var init = repo.MerkBarangs.Select(m => new
        {
            merkBarangId = m.MerkBarangID,
            namaMerk = m.NamaMerk,
            namaJenis = m.JenisBarang.NamaJenis
        });

        if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
        {
            init = init.OrderBy(sortColumn + " " + sortColumnDirection);
        }

        if (!string.IsNullOrEmpty(searchValue))
        {
            init = init.Where(a => a.namaMerk.ToLower().Contains(searchValue.ToLower()));
        }

        recordsTotal = init.Count();

        var result = await init.Skip(skip).Take(pageSize).ToListAsync();

        var jsonData = new { draw, recordsFiltered = recordsTotal, recordsTotal, data = result };

        return Ok(jsonData);
    }

    [HttpPost("/api/barang/tipe")]
    public async Task<IActionResult> TipeBarangTable()
    {
        var draw = Request.Form["draw"].FirstOrDefault();
        var start = Request.Form["start"].FirstOrDefault();
        var length = Request.Form["length"].FirstOrDefault();
        var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
        var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
        var searchValue = Request.Form["search[value]"].FirstOrDefault();
        int pageSize = length != null ? Convert.ToInt32(length) : 0;
        int skip = start != null ? Convert.ToInt32(start) : 0;
        int recordsTotal = 0;

        var init = repo.TipeBarangs.Select(m => new
        {
            tipeBarangId = m.TipeBarangID,
            namaTipe = m.NamaTipe,
            namaMerk = m.MerkBarang.NamaMerk,
            namaJenis = m.MerkBarang.JenisBarang.NamaJenis
        });

        if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
        {
            init = init.OrderBy(sortColumn + " " + sortColumnDirection);
        }

        if (!string.IsNullOrEmpty(searchValue))
        {
            init = init.Where(a => a.namaMerk.ToLower().Contains(searchValue.ToLower()));
        }

        recordsTotal = init.Count();

        var result = await init.Skip(skip).Take(pageSize).ToListAsync();

        var jsonData = new { draw, recordsFiltered = recordsTotal, recordsTotal, data = result };

        return Ok(jsonData);
    }

    [HttpGet("/api/barang/jenis/search")]
    public async Task<IActionResult> SearchJenis(string? term)
    {
        var data = await repo.JenisBarangs            
            .Where(k => !String.IsNullOrEmpty(term) ?
                k.NamaJenis.ToLower().Contains(term.ToLower()) : true
            ).Select(s => new {
                id = s.JenisBarangID,
                namaJenis = s.NamaJenis
            }).Take(10).ToListAsync();

        return Ok(data);
    }

#nullable enable

    [HttpGet("/api/barang/merk/search")]
    public async Task<IActionResult> Search(string? term, int jenis)
    {
        var data = await repo.MerkBarangs
            .Where(k => k.JenisBarangId == jenis )
            .Where(k => !String.IsNullOrEmpty(term) ?
                k.NamaMerk.ToLower().Contains(term.ToLower()) : true
            ).Select(s => new {
                id = s.MerkBarangID,
                namaMerk = s.NamaMerk
            }).Take(10).ToListAsync();

        return Ok(data);
    }

}
