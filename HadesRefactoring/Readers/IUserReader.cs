namespace HadesRefactoring.Readers;

public interface IUserReader
{
    public User.User? GetByUsername(string username);
}