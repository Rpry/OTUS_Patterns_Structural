using BridgeRepository.Models;
using BridgeRepository.Storages;

namespace BridgeRepository.Repositories;

public abstract class UserRepository
{
    protected readonly IUserStorage _storage;
    
    protected UserRepository(IUserStorage storage)
    {
        _storage = storage;
    }
    
    public abstract User GetUserById(string userId);
    public abstract void CreateUser(User user);
    public abstract void UpdateUser(User user);
    public abstract void RemoveUser(string userId);
}