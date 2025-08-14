using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.ContactCommands
{
    public class RemoveContactCommand : IRequest
    {
        public int ContactId { get; set; }

        public RemoveContactCommand(int contactId)
        {
            ContactId = contactId;
        }
    }
}
