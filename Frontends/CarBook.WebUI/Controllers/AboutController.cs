using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title1 = "Hakkımızda";
            ViewBag.Title2 = "Vizyon & Misyon";
            return View();
        }
    }
}
