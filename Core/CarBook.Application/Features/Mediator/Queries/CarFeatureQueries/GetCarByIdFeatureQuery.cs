using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CarFeatureQueries
{
    public class GetCarByIdFeatureQuery : IRequest<List<GetCarByIdFeatureQueryResult>>
    {
        public int Id { get; set; }

        public GetCarByIdFeatureQuery(int id)
        {
            Id = id;
        }
    }
}
