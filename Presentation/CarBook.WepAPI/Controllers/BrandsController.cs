using CarBook.Application.Features.Mediator.Commands.BrandCommands;
using CarBook.Application.Features.Mediator.Queries.BrandQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBrandList()
        {
            var values = await _mediator.Send(new GetBrandQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(int id)
        {
            var value = await _mediator.Send(new GetBrandByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await _mediator.Send(command);
            return Ok("Marka Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await _mediator.Send(command);
            return Ok("Marka Bilgisi Güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBrand(int id)
        {
            await _mediator.Send(new RemoveBrandCommand(id));
            return Ok("Marka Bilgisi Silindi.");
        }
    }
}
