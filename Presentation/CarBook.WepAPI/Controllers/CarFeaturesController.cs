using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarByIdFeature(int id)
        {
            var values = await _mediator.Send(new GetCarByIdFeatureQuery(id));
            return Ok(values);
        }

        [HttpGet("GetFeatureChangeAvailableToFalse")]
        public async Task<IActionResult> GetFeatureChangeAvailableToFalse(int id)
        {
            await _mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(id));
            return Ok("Available 'false' olarak değiştirildi.");
        }

        [HttpGet("GetFeatureChangeAvailableToTrue")]
        public async Task<IActionResult> GetFeatureChangeAvailableToTrue(int id)
        {
            await _mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(id));
            return Ok("Available 'true' olarak değiştirildi.");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarFeatureByCarId(CreateCarFeatureByCarCommand command)
        {
            await _mediator.Send(command);
            return Ok("Araba özelliği eklendi.");
        }
    }
}
