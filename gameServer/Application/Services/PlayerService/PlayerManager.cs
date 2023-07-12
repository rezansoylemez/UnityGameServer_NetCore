using Application.Repositories;
using Core.Domain.Models;  

namespace Application.Services.PlayerService;

public class PlayerManager : IPlayerService
{
    private readonly IPlayerRepository _playerRepository;

    public PlayerManager(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    public async Task<Player> Create(Player player)
    {
        var createdPlayer = await _playerRepository.InsertOneAsync(player);
        return createdPlayer;
    }

    public async Task<Player> Delete(Player player)
    {
        var deleted = await _playerRepository.ReplaceOneAsync(document: player);
        return deleted;

    }
    public async Task<Player> Update(Player player)
    {
        var updatedPlayer = await _playerRepository.ReplaceOneAsync(player);
        return updatedPlayer;
    }


    public async Task<Player> GetById(string id)
    {
        var player = await _playerRepository.FindByIdAsync(id: id);
        return player;
    }

    public async Task<Player> Remove(Player player)
    {
        var deleted = await _playerRepository.DeleteAsync(document: player);
        return deleted;
    }
     
}
