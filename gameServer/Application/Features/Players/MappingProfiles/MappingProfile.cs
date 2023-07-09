using Application.Features.Players.Commands.Create;
using AutoMapper;
using Domain.EntityModels;

namespace Application.Features.Players.MappingProfiles;
public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Player, CreatedPlayerCommandResponse>().ReverseMap();
        CreateMap<Player, CreatePlayerCommandRequest>().ReverseMap();
         
    }
}
