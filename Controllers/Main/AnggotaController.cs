using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Koperasi.Controllers;


public class AnggotaController : Controller
{
    [HttpGet("/anggota/list")]
	[Authorize(Roles = "SysAdmin, KoperasiAdmin")]
	public IActionResult List()
    {
        return View("~/Views/Main/Anggota/List.cshtml");
    }
}
