using CarBook.Application.Features.Mediator.Queries.CarQueries;
using CarBook.Application.Features.Mediator.Results.CarResults;
using CarBook.Application.Interfaces.CarRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarHandlers
{
    public class GetCarByIdWithBrandNameQueryHandler : IRequestHandler<GetCarByIdWithBrandNameQuery, GetCarByIdWithBrandNameQueryResult>
    {
        private readonly ICarRepository _repository;

        public GetCarByIdWithBrandNameQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdWithBrandNameQueryResult> Handle(GetCarByIdWithBrandNameQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetCarByIdWithBrand(request.Id);
            return new GetCarByIdWithBrandNameQueryResult
            {
                BigImageUrl = value.BigImageUrl,
                BrandId = value.BrandId,
                BrandName = value.Brand.Name,
                CarId = value.CarId,
                CoverImageUrl = value.CoverImageUrl,
                Fuel = value.Fuel,
                Kilometer = value.Kilometer,
                Luggage = value.Luggage,
                Model = value.Model,
                Seat = value.Seat,
                Transmission = value.Transmission
            };
        }
    }
}
