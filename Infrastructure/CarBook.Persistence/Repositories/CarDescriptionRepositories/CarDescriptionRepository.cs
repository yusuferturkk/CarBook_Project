using CarBook.Application.Interfaces.CarDescriptionInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookContext _contextc;

        public CarDescriptionRepository(CarBookContext contextc)
        {
            _contextc = contextc;
        }

        public Task<CarDescription> GetCarDescription(int id)
        {
            return _contextc.Set<CarDescription>().Where(x => x.CarId == id).FirstAsync();
        }
    }
}
