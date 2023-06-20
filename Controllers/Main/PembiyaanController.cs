using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Koperasi.Controllers.Main
{
    public class PembiyaanController : Controller
    {
        [HttpGet("/pembiyaan/list")]
        [Authorize(Roles = "SysAdmin, KoperasiAdmin")]
        public IActionResult List()
        {
            return View("~/Views/Main/Pembiyaan/List.cshtml");
        }

        [HttpGet("/pembiyaan/create")]
        public IActionResult Create()
        {
            return PartialView("~/Views/Main/Pembiyaan/AddEdit.cshtml");
        }

        [HttpGet("/pembiyaan/bayar")]
        public IActionResult Pay()
        {
            return PartialView("~/Views/Main/Pembiyaan/Bayar.cshtml");
        }

        [HttpGet("/pembiyaan/details")]
        public IActionResult Details()
        {
            return View("~/Views/Main/Pembiyaan/Details.cshtml");
        }
    }
}
