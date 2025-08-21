using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarByIdFeatureHandler : IRequestHandler<GetCarByIdFeatureQuery, List<GetCarByIdFeatureQueryResult>>
    {
        private readonly ICarFeatureRepository _repository;

        public GetCarByIdFeatureHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarByIdFeatureQueryResult>> Handle(GetCarByIdFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarByIdFeature(request.Id);
            return values.Select(x => new GetCarByIdFeatureQueryResult
            {
                Available = x.Available,
                CarFeatureId = x.CarFeatureId,
                CarId = x.CarId,
                FeatureId = x.FeatureId,
                FeatureName = x.Feature.Name,
            }).ToList();
        }
    }
}
