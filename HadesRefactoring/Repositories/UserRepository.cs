namespace HadesRefactoring.Repositories;

public class UserRepository : IUserRepository
{
    public static List<User.User> Users = new List<User.User>()
    {
        new User.User("oguzhanTunaIsmail", "asdasd")
    };

    public User.User? GetByUsername(string username)
    {
        return Users.FirstOrDefault(u => u.Username == username);
    }
}