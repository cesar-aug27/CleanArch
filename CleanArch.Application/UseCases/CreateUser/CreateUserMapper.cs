using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.UseCases.CreateUser
{
    public sealed record CreateUserMapper : Profile
    {

        internal CreateUserMapper(string profileName) : base(profileName)
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<CreateUser, CreateUserResponse>();
        }

        internal CreateUserMapper(string profileName, Action<IProfileExpression> configurationAction) : base(profileName, configurationAction)
        {
        }
    }
}
