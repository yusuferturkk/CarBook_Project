using CarBook.Application.Features.Mediator.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarHandlers
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand>
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = request.BigImageUrl,
                BrandId = request.BrandId,
                CoverImageUrl = request.CoverImageUrl,
                Fuel = request.Fuel,
                Kilometer = request.Kilometer,
                Luggage = request.Luggage,
                Model = request.Model,
                Seat = request.Seat,
                Transmission = request.Transmission,
            });
        }
    }
}
