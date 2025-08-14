using CarBook.Application.Features.Mediator.Results.BannerResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.BannerQueries
{
    public class GetBannerByIdQuery : IRequest<GetBannerByIdQueryResult>
    {
        public int BannerId { get; set; }

        public GetBannerByIdQuery(int bannerId)
        {
            BannerId = bannerId;
        }
    }
}
