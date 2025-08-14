using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title1 = "Bloglar";
            ViewBag.Title2 = "Bloglarımız";
            return View();
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.Title1 = "Bloglar";
            ViewBag.Title2 = "Blog Detayı";
            ViewBag.BlogId = id;
            return View();
        }
    }
}
