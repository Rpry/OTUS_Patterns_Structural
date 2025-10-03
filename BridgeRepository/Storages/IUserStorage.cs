using BridgeRepository.Models;

namespace BridgeRepository.Storages;

public interface IUserStorage
{
    User GetUser(string userId);
    void SaveUser(User user);
    void DeleteUser(string userId);
    List<User> FindUsers(Func<User, bool> predicate);
}