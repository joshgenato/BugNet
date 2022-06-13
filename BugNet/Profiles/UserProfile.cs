using AutoMapper;
using BugNet.Dtos;
using Microsoft.AspNetCore.Identity;

namespace BugNet.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<IdentityUser, CommandReadUserDto>();
            CreateMap<CommandCreateUserDto, IdentityUser>();
            CreateMap<CommandUpdateUserDto, IdentityUser>();
            CreateMap<IdentityUser, CommandUpdateUserDto>();
        }
    }
}