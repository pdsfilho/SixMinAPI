using  AutoMapper;
using SixMinAPI.Dtos;
using SixMinAPI.Models;

namespace SixMinAPI.Profiles
{
    public class CommandsProfile: Profile
    {
        public CommandsProfile()
        {
            //Source -> target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}