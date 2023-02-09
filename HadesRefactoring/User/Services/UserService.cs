using HadesRefactoring.BuildingBlocks;
using HadesRefactoring.Readers;
using HadesRefactoring.User.Rules.SemanticRules;

namespace HadesRefactoring.User.Services;

public class UserService
{
    private readonly SemanticUserEvaluator _semanticUserEvaluator;
    private readonly IUserReader _userReader;
    
    public UserService(SemanticUserEvaluator semanticUserEvaluator, IUserReader userReader)
    {
        _semanticUserEvaluator = semanticUserEvaluator;
        _userReader = userReader;
    }

    public void CreateUser(string username, string password)
    {
        var user = new User(username, password); // syntactic validations done in constructor and if there is an error exception will be thrown

        var rules = new List<IRule>()
        {
            new EnsureUsernameMustBeUniqueRule(_userReader, username)
        };
        _semanticUserEvaluator.SetRules(rules);
        _semanticUserEvaluator.Execute();
    }
    
}