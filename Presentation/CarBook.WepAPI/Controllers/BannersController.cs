using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly CreateBannerCommandHandler _createCommandHandler;
        private readonly UpdateBannerCommandHandler _updateCommandHandler;
        private readonly RemoveBannerCommandHandler _removeCommandHandler;
        private readonly GetBannerByIdQueryHandler _getBannerByIdQueryHandler;
        private readonly GetBannerQueryHandler _getBannerQueryHandler;

        public BannersController(CreateBannerCommandHandler createCommandHandler, UpdateBannerCommandHandler updateCommandHandler, RemoveBannerCommandHandler removeCommandHandler, GetBannerByIdQueryHandler getCommandHandler, GetBannerQueryHandler getQueryHandler)
        {
            _createCommandHandler = createCommandHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
            _getBannerByIdQueryHandler = getCommandHandler;
            _getBannerQueryHandler = getQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetBannerList()
        {
            var values = await _getBannerQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBannerById(int id)
        {
            var value = await _getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Banner Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Banner Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBanner(int id)
        {
            await _removeCommandHandler.Handle(new RemoveBannerCommand(id));
            return Ok("Banner Bilgisi Silindi.");
        }
    }
}
