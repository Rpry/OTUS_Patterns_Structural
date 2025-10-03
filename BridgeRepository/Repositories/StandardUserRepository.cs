using BridgeRepository.Models;
using BridgeRepository.Storages;

namespace BridgeRepository.Repositories;

public class StandardUserRepository : UserRepository
{
    public StandardUserRepository(IUserStorage storage) : base(storage) { }
    
    public override User GetUserById(string userId)
    {
        Console.WriteLine("StandardUserRepository: Получение пользователя");
        return _storage.GetUser(userId);
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
