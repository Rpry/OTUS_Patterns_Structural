using BridgeRepository.Models;
using BridgeRepository.Storages;

namespace BridgeRepository.Repositories;

public class CachingUserRepository : UserRepository
{
    private readonly Dictionary<string, User> _cache = new Dictionary<string, User>();
    
    public CachingUserRepository(IUserStorage storage) : base(storage) { }
    
    public override User GetUserById(string userId)
    {
        if (_cache.TryGetValue(userId, out User cachedUser))
        {
            Console.WriteLine("Получено из кэша");
            return cachedUser;
        }
        
        var user = _storage.GetUser(userId);
        _cache[userId] = user;
        return user;
    }

    public override void CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public override void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public override void RemoveUser(string userId)
    {
        throw new NotImplementedException();
    }
}