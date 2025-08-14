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
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand>
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.CarId);
            value.Fuel = request.Fuel;
            value.Transmission = request.Transmission;
            value.BigImageUrl = request.BigImageUrl;
            value.Luggage = request.Luggage;
            value.Seat = request.Seat;
            value.Kilometer = request.Kilometer;
            value.BrandId = request.BrandId;
            value.CoverImageUrl = request.CoverImageUrl;
            value.Model = request.Model;
            await _repository.UpdateAsync(value);
        }
    }
}
