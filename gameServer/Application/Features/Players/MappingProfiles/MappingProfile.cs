using Application.Features.Players.Commands.Create;
using AutoMapper;
using Core.Domain.Models;

namespace Application.Features.Players.MappingProfiles;
public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Player, CreatePlayerCommandRequest>().ReverseMap();
        CreateMap<Player, CreatedPlayerCommandResponse>().ReverseMap();

    }
}
