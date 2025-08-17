﻿using CarBook.Dto.StatisticDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistic")]
    public class AdminStatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            #region İstatistik1
            var responseMessage = await client.GetAsync("https://localhost:7200/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int carCountRandom = random.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.carCount = values?.carCount;
                ViewBag.carCountRandom = carCountRandom;
            }
            #endregion

            #region İstatistik2
            var responseMessage2 = await client.GetAsync("https://localhost:7200/api/Statistics/GetAuthorCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int authorCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData2);
                ViewBag.authorCount = values2?.authorCount;
                ViewBag.authorCountRandom = authorCountRandom;
            }
            #endregion

            #region İstatistik3
            var responseMessage3 = await client.GetAsync("https://localhost:7200/api/Statistics/GetBlogCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int blogCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData3);
                ViewBag.blogCount = values3?.blogCount;
                ViewBag.blogCountRandom = blogCountRandom;
            }
            #endregion

            #region İstatistik4
            var responseMessage4 = await client.GetAsync("https://localhost:7200/api/Statistics/GetBrandCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData4);
                ViewBag.brandCount = values4?.brandCount;
                ViewBag.brandCountRandom = brandCountRandom;
            }
            #endregion

            #region İstatistik5
            var responseMessage5 = await client.GetAsync("https://localhost:7200/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int avgRentPriceForDailyRandom = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData5);
                ViewBag.avgRentPriceForDaily = values5?.avgPriceForDaily.ToString("F2");
                ViewBag.avgRentPriceForDailyRandom = avgRentPriceForDailyRandom;
            }
            #endregion

            #region İstatistik6
            var responseMessage6 = await client.GetAsync("https://localhost:7200/api/Statistics/GetAvgRentPriceForHourly");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int avgRentPriceForHourlyRandom = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData6);
                ViewBag.avgRentPriceForHourly = values6?.avgPriceForHourly.ToString("F2");
                ViewBag.avgRentPriceForHourlyRandom = avgRentPriceForHourlyRandom;
            }
            #endregion

            #region İstatistik7
            var responseMessage7 = await client.GetAsync("https://localhost:7200/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int avgRentPriceForWeeklyRandom = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData7);
                ViewBag.avgRentPriceForWeekly = values7?.avgRentPriceForWeekl.ToString("F2");
                ViewBag.avgRentPriceForWeeklyRandom = avgRentPriceForWeeklyRandom;
            }
            #endregion

            #region İstatistik8
            var responseMessage8 = await client.GetAsync("https://localhost:7200/api/Statistics/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int avgRentPriceForMonthlyRandom = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData8);
                ViewBag.avgRentPriceForMonthly = values8?.avgRentPriceForMonthly.ToString("F2");
                ViewBag.avgRentPriceForMonthlyRandom = avgRentPriceForMonthlyRandom;
            }
            #endregion

            #region İstatistik9
            var responseMessage9 = await client.GetAsync("https://localhost:7200/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int carCountByTranmissionIsAutoRandom = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData9);
                ViewBag.carCountByTranmissionIsAuto = values9?.carCountByTranmissionIsAuto;
                ViewBag.carCountByTranmissionIsAutoRandom = carCountByTranmissionIsAutoRandom;
            }
            #endregion

            #region İstatistik10
            var responseMessage10 = await client.GetAsync("https://localhost:7200/api/Statistics/GetBrandNameByMaxCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int brandNameByMaxCarRandom = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData10);
                ViewBag.brandNameByMaxCar = values10?.brandNameByMaxCar;
                ViewBag.brandNameByMaxCarRandom = brandNameByMaxCarRandom;
            }
            #endregion

            #region İstatistik11
            var responseMessage11 = await client.GetAsync("https://localhost:7200/api/Statistics/GetBlogTitleByMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int blogTitleByMaxBlogCommentRandom = random.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData11);
                ViewBag.blogTitleByMaxBlogComment = values11?.blogTitleByMaxBlogComment;
                ViewBag.blogTitleByMaxBlogCommentRandom = blogTitleByMaxBlogCommentRandom;
            }
            #endregion

            #region İstatistik12
            var responseMessage12 = await client.GetAsync("https://localhost:7200/api/Statistics/GetCarCountByKmSmallerThen50000");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int carCountByKmSmallerThen50000Random = random.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData12);
                ViewBag.carCountByKmSmallerThen1000 = values12?.carCountByKmSmallerThen1000;
                ViewBag.carCountByKmSmallerThen1000Random = carCountByKmSmallerThen50000Random;
            }
            #endregion

            #region İstatistik13
            var responseMessage13 = await client.GetAsync("https://localhost:7200/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int carCountByFuelGasolineOrDieselRandom = random.Next(0, 101);
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData13);
                ViewBag.carCountByFuelGasolineOrDiesel = values13?.carCountByFuelGasolineOrDiesel;
                ViewBag.carCountByFuelGasolineOrDieselRandom = carCountByFuelGasolineOrDieselRandom;
            }
            #endregion

            #region İstatistik14
            var responseMessage14 = await client.GetAsync("https://localhost:7200/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int carCountByFuelElectricRandom = random.Next(0, 101);
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData14);
                ViewBag.carCountByFuelElectric = values14?.carCountByFuelElectric;
                ViewBag.carCountByFuelElectricRandom = carCountByFuelElectricRandom;
            }
            #endregion

            #region İstatistik15
            var responseMessage15 = await client.GetAsync("https://localhost:7200/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceDailyMaxRandom = random.Next(0, 101);
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData15);
                ViewBag.carBrandAndModelByRentPriceDailyMax = values15?.carBrandAndModelByRentPriceDailyMax;
                ViewBag.carBrandAndModelByRentPriceDailyMaxRandom = carBrandAndModelByRentPriceDailyMaxRandom;
            }
            #endregion

            #region İstatistik16
            var responseMessage16 = await client.GetAsync("https://localhost:7200/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceDailyMinRandom = random.Next(0, 101);
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData16);
                ViewBag.carBrandAndModelByRentPriceDailyMin = values16?.carBrandAndModelByRentPriceDailyMin;
                ViewBag.carBrandAndModelByRentPriceDailyMinRandom = carBrandAndModelByRentPriceDailyMinRandom;
            }
            #endregion

            return View();
        }
    }
}
