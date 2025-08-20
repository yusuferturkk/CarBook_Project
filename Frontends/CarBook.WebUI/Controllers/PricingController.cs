using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title1 = "Paketler";
            ViewBag.Title2 = "Araç Fiyat Paketleri";
            return View();
        }
    }
}
