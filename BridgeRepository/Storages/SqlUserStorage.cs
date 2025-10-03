using BridgeRepository.Models;

namespace BridgeRepository.Storages;

public class SqlUserStorage : IUserStorage
{
    private readonly string _connectionString;
    
    public SqlUserStorage(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public User GetUser(string userId)
    {
        // SQL-специфичная реализация получения пользователя
        Console.WriteLine($"Получение пользователя {userId} из SQL БД");
        return new User { Id = userId, Name = "SQL User" };
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