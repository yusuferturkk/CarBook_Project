using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using CarBook.Application.Features.Mediator.Results.StatisticResults;
using CarBook.Application.Interfaces.StatisticInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetCarCountByKmSmallerThen50000QueryHandler : IRequestHandler<GetCarCountByKmSmallerThen50000Query, GetCarCountByKmSmallerThen50000QueryResult>
    {
        private readonly IStatisticRepository _repository;

        public GetCarCountByKmSmallerThen50000QueryHandler(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmSmallerThen50000QueryResult> Handle(GetCarCountByKmSmallerThen50000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmSmallerThen50000();
            return new GetCarCountByKmSmallerThen50000QueryResult
            {
                CarCountByKmSmallerThen1000 = value
            };
        }
    }
}
