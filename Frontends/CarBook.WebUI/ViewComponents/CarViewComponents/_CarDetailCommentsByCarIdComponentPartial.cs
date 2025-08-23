using CarBook.Dto.CarFeatureDtos;
using CarBook.Dto.ReviewDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.CarViewComponents
{
    public class _CarDetailCommentsByCarIdComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _CarDetailCommentsByCarIdComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.CarId = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7200/api/Reviews/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultsReviewByIdCarDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
