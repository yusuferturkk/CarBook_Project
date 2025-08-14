using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.AboutCommands
{
    public class RemoveAboutCommand : IRequest
    {
        public int AboutId { get; set; }

        public RemoveAboutCommand(int aboutId)
        {
            AboutId = aboutId;
        }
    }
}
