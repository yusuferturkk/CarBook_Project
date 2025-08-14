using CarBook.Application.Features.Mediator.Queries.CarQueries;
using CarBook.Application.Features.Mediator.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarRepository;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler : IRequestHandler<GetCarWithBrandQuery, List<GetCarWithBrandQueryResult>>
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarWithBrandQueryResult>> Handle(GetCarWithBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetCarsListWithBrand();
            return values.Select(x => new GetCarWithBrandQueryResult
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
                BrandName = x.Brand.Name,
            }).ToList();
        }
    }
}
