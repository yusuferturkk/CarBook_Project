using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.CategoryCommands
{
    public class RemoveCategoryCommand : IRequest
    {
        public int CategoryId { get; set; }

        public RemoveCategoryCommand(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
