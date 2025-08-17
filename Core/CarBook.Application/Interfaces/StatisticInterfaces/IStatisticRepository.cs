using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.StatisticInterfaces
{
    public interface IStatisticRepository
    {
        int GetCarCount();
        int GetAuthorCount();
        int GetBlogCount();
        int GetBrandCount();
        decimal GetAvgRentPriceForDaily();
        decimal GetAvgRentPriceForHourly();
        decimal GetAvgRentPriceForWeekly();
        decimal GetAvgRentPriceForMonthly();
        int GetCarCountByTransmissionIsAuto();
        string GetBrandNameByMaxCar();
        string GetBlogTitleByMaxBlogComment();
        int GetCarCountByFuelGasolineOrDiesel();
        int GetCarCountByFuelElectric();
        int GetCarCountByKmSmallerThen50000();
        string GetCarBrandAndModelByRentPriceDailyMin();
        string GetCarBrandAndModelByRentPriceDailyMax();
    }
}
