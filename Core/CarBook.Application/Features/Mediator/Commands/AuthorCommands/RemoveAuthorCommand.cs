﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.AuthorCommands
{
    public class RemoveAuthorCommand : IRequest
    {
        public int AuthorId { get; set; }

        public RemoveAuthorCommand(int authorId)
        {
            AuthorId = authorId;
        }
    }
}
