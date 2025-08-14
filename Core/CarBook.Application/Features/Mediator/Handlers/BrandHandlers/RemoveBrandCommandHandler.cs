using CarBook.Application.Features.Mediator.Commands.BrandCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler : IRequestHandler<RemoveBrandCommand>
    {
        private readonly IRepository<Brand> _repository;

        public RemoveBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBrandCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BrandId);
            await _repository.RemoveAsync(value);
        }
    }
}
