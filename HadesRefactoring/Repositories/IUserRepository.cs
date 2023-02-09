namespace HadesRefactoring.Repositories;

public interface IUserRepository
{
    public User.User? GetByUsername(string username);
}