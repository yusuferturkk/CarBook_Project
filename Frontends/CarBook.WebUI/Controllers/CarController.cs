using CarBook.Dto.CarDtos;
using CarBook.Dto.CarFeatureDtos;
using CarBook.Dto.FeatureDtos;
using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title1 = "Araçlarımız";
            ViewBag.Title2 = "Aracınızı Seçiniz";

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7200/api/CarPricings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarsWithPricingDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> CarDetail(int id)
        {
            ViewBag.Title1 = "Araçlarımız";
            ViewBag.Title2 = "Araç Detayları";
            ViewBag.CarId = id;
            return View();
        }
    }
}
