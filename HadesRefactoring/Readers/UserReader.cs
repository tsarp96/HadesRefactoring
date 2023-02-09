using HadesRefactoring.Repositories;

namespace HadesRefactoring.Readers;

public class UserReader : IUserReader
{
    private readonly IUserRepository _userRepository;

    public UserReader(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User.User? GetByUsername(string username)
    {
        return _userRepository.GetByUsername(username);
    }
}