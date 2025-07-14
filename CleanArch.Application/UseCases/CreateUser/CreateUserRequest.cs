using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.UseCases.CreateUser
{
    public sealed record CreateUserRequest(string email, string name):
        IRequest<CreateUserResponse>
    {

    }
}
