using CarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDescriptionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarDescriptionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarDescription(int id)
        {
            var value = await _mediator.Send(new GetCarDescriptionByCarIdQuery(id));
            return Ok(value);
        }

    }
}
