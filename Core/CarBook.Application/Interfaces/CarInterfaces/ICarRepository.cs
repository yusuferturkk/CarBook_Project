using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarRepository
{
    public interface ICarRepository
    {
        Task<Car> GetCarByIdWithBrand(int id);
        Task<List<Car>> GetCarsListWithBrand();
        Task<List<Car>> GetLastFiveCarsWithBrand();
    }
}
