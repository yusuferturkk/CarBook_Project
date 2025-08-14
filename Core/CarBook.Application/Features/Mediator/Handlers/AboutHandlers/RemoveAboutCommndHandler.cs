using CarBook.Application.Features.Mediator.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class RemoveAboutCommndHandler : IRequestHandler<RemoveAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public RemoveAboutCommndHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAboutCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.AboutId);
            await _repository.RemoveAsync(value);
        }
    }
}
