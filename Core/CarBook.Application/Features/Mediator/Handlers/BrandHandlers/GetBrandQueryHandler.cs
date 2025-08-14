using CarBook.Application.Features.Mediator.Queries.BrandQueries;
using CarBook.Application.Features.Mediator.Results.BrandResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler : IRequestHandler<GetBrandQuery, List<GetBrandQueryResult>>
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBrandQueryResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult
            {
                BrandId = x.BrandId,
                Name = x.Name,
            }).ToList();
        }
    }
}
