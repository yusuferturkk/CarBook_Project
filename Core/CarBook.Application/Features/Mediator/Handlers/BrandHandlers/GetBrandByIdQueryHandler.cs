using CarBook.Application.Features.Mediator.Queries.BrandQueries;
using CarBook.Application.Features.Mediator.Results.BannerResults;
using CarBook.Application.Features.Mediator.Results.BrandResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, GetBrandByIdQueryResult>
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BrandId);
            return new GetBrandByIdQueryResult
            {
                BrandId = value.BrandId,
                Name = value.Name,
            };
        }
    }
}
