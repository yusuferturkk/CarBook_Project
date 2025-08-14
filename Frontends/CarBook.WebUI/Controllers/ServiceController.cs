using CarBook.Dto.AboutDtos;
using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title1 = "Hizmetler";
            ViewBag.Title2 = "Hizmetlerimiz";
            return View();
        }
    }
}
