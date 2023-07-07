using Domain.EntityModels;

namespace Application.Services.PlayerService;

public interface IPlayerService 
{
    Task<Player> Create(Player player);
    Task<Player> Update(Player player);
    Task<Player> Delete(Player player);
    Task<Player> Remove(Player player);
    Task<Player> GetById(string id);
}
