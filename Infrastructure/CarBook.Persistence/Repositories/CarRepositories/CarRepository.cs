using CarBook.Application.Interfaces.CarRepository;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetCarsListWithBrand()
        {
            return await _context.Set<Car>().Include(x => x.Brand).ToListAsync();
        }

        public async Task<List<Car>> GetLastFiveCarsWithBrand()
        {
            var values = await _context.Set<Car>().Include(x => x.Brand).OrderByDescending(x => x.CarId).Take(5).ToListAsync();
            return values;
        }
    }
}
