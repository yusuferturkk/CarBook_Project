using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLastThreeBlogsQueryHandler : IRequestHandler<GetLastThreeBlogsWithAuthorQuery, List<GetLastThreeBlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetLastThreeBlogsQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetLastThreeBlogsWithAuthorQueryResult>> Handle(GetLastThreeBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _blogRepository.GetLastThreeBlogsWithAuthor();
            return values.Select(x => new GetLastThreeBlogsWithAuthorQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                BlogId = x.BlogId,
                CategoryId = x.CategoryId,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Title = x.Title,
            }).ToList();
        }
    }
}
