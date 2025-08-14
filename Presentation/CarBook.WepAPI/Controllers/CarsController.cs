using CarBook.Application.Features.Mediator.Commands.CarCommands;
using CarBook.Application.Features.Mediator.Queries.CarQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarList()
        {
            var values = await _mediator.Send(new GetCarQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            var value = await _mediator.Send(new GetCarByIdQuery(id));
            return Ok(value);
        }

        [HttpGet("GetCarWithBrand")]
        public async Task<IActionResult> GetCarWithBrand()
        {
            var value = await _mediator.Send(new GetCarWithBrandQuery());
            return Ok(value);
        }

        [HttpGet("GetLastFiveCarsWithBrand")]
        public async Task<IActionResult> GetLastFiveCarsWithBrand()
        {
            var value = await _mediator.Send(new GetLastFiveCarsWithBrandQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _mediator.Send(command);
            return Ok("Marka Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _mediator.Send(command);
            return Ok("Marka Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await _mediator.Send(new RemoveCarCommand(id));
            return Ok("Marka Bilgisi Silindi.");
        }
    }
}
