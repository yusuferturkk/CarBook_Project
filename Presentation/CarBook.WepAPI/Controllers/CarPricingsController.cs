using CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;
using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarPricingWithCarList()
        {
            var value = await _mediator.Send(new GetCarPricingWithCarQuery());
            return Ok(value);
        }

        [HttpGet("GetCarPricingWithTimePeriodList")]
        public async Task<IActionResult> GetCarPricingWithTimePeriodList()
        {
            var values = await _mediator.Send(new GetCarPricingWithTimePeriodQuery());
            return Ok(values);
        }
    }
}
