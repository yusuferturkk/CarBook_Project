using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLastFiveCarsWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetLastFiveCarsWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLastFiveCarsWithBrandQueryResult>> Handle()
        {
            var values = await _repository.GetLastFiveCarsWithBrand();
            return values.Select(x => new GetLastFiveCarsWithBrandQueryResult
            {
                CarId = x.CarId,
                BrandId = x.BrandId,
                BigImageUrl = x.BigImageUrl,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Kilometer = x.Kilometer,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission,
                Brand = x.Brand.Name,
            }).ToList();
        }
    }
}
