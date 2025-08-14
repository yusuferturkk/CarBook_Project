using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CarDtos
{
    public class ResultCarsWithPricingDto
    {
        public int CarPricingId { get; set; }
        public int CarId { get; set; }
        public int PricingId { get; set; }
        public decimal Amount { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
