using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBook.WebUI.ViewComponents.CarViewComponents
{
    public class _CarDetailMainCarFeatureComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _CarDetailMainCarFeatureComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.CarId = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7200/api/Cars/GetCarByIdWithBrand/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultCarByIdWithBrandNameDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
