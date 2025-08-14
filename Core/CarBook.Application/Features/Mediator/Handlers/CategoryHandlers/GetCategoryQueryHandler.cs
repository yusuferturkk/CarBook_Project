﻿using CarBook.Application.Features.Mediator.Queries.CategoryQueries;
using CarBook.Application.Features.Mediator.Results.CategoryResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                Name = x.Name,
            }).ToList();
        }
    }
}
