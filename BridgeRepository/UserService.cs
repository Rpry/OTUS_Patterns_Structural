using BridgeRepository.Models;
using BridgeRepository.Repositories;

namespace BridgeRepository;

public class UserService
{
    private readonly UserRepository _userRepository;
    
    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public User GetUser(string userId)
    {
        return _userRepository.GetUserById(userId);
    }
    
    // Другие методы сервиса...
}