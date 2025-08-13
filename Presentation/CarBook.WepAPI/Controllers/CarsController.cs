using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CreateCarCommandHandler _createCommandHandler;
        private readonly UpdateCarCommandHandler _updateCommandHandler;
        private readonly RemoveCarCommandHandler _removeCommandHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdCommandHandler;
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
        private readonly GetLastFiveCarsWithBrandQueryHandler _getLastFiveCarsWithBrandQueryHandler;

        public CarsController(CreateCarCommandHandler createCommandHandler, UpdateCarCommandHandler updateCommandHandler, RemoveCarCommandHandler removeCommandHandler, GetCarByIdQueryHandler getCarByIdCommandHandler, GetCarQueryHandler getCarQueryHandler, GetCarWithBrandQueryHandler getCarWithBrandQueryHandler, GetLastFiveCarsWithBrandQueryHandler getLastFiveCarsWithBrandQueryHandler)
        {
            _createCommandHandler = createCommandHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
            _getCarByIdCommandHandler = getCarByIdCommandHandler;
            _getCarQueryHandler = getCarQueryHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
            _getLastFiveCarsWithBrandQueryHandler = getLastFiveCarsWithBrandQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarList()
        {
            var values = await _getCarQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            var value = await _getCarByIdCommandHandler.Handle(new GetCarByIdQuery(id));
            return Ok(value);
        }

        [HttpGet("GetCarWithBrand")]
        public async Task<IActionResult> GetCarWithBrand()
        {
            var value = await _getCarWithBrandQueryHandler.Handle();
            return Ok(value);
        }

        [HttpGet("GetLastFiveCarsWithBrand")]
        public async Task<IActionResult> GetLastFiveCarsWithBrand()
        {
            var value = await _getLastFiveCarsWithBrandQueryHandler.Handle();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Araba Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Araba Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await _removeCommandHandler.Handle(new RemoveCarCommand(id));
            return Ok("Araba Bilgisi Silindi.");
        }
    }
}
