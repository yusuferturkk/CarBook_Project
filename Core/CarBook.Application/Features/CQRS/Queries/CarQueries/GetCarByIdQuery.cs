using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIdQuery
    {
        public int CarId { get; set; }

        public GetCarByIdQuery(int carId)
        {
            CarId = carId;
        }
    }
}
