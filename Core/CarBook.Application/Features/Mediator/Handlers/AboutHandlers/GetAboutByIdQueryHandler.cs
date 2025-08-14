using CarBook.Application.Features.Mediator.Queries.AboutQueries;
using CarBook.Application.Features.Mediator.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQuery, GetAboutByIdQueryResult>
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.AboutId);
            return new GetAboutByIdQueryResult
            {
                AboutId = value.AboutId,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                Title = value.Title,
            };
        }
    }
}
