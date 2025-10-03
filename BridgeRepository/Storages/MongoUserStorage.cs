using BridgeRepository.Models;

namespace BridgeRepository.Storages;

public class MongoUserStorage : IUserStorage
{
    private readonly string _connectionString;
    
    public MongoUserStorage(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public User GetUser(string userId)
    {
        // MongoDB-специфичная реализация
        Console.WriteLine($"Получение пользователя {userId} из MongoDB");
        return new User { Id = userId, Name = "Mongo User" };
    }

    public void SaveUser(User user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(string userId)
    {
        throw new NotImplementedException();
    }

    public List<User> FindUsers(Func<User, bool> predicate)
    {
        throw new NotImplementedException();
    }
}