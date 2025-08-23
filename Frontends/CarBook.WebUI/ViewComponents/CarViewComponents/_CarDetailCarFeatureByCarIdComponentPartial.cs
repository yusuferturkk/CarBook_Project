using CarBook.Dto.CarFeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBook.WebUI.ViewComponents.CarViewComponents
{
    public class _CarDetailCarFeatureByCarIdComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _CarDetailCarFeatureByCarIdComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.CarId = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7200/api/CarFeatures?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetCarByIdFeatureDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
