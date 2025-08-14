using CarBook.Application.Features.Mediator.Queries.BannerQueries;
using CarBook.Application.Features.Mediator.Results.AboutResults;
using CarBook.Application.Features.Mediator.Results.BannerResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler : IRequestHandler<GetBannerByIdQuery, GetBannerByIdQueryResult>
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BannerId);
            return new GetBannerByIdQueryResult
            {
                BannerId = value.BannerId,
                Title = value.Title,
                Description = value.Description,
                VideoDescription = value.VideoDescription,
                VideoUrl = value.VideoUrl,
            };
        }
    }
}
