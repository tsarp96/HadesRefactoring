using HadesRefactoring.BuildingBlocks;
using HadesRefactoring.Readers;

namespace HadesRefactoring.User.Rules.SemanticRules;

public class EnsureUsernameMustBeUniqueRule : IRule
{
    private readonly IUserReader _userReader;
    public string Username { get; set; }

    public EnsureUsernameMustBeUniqueRule(IUserReader userReader, string username)
    {
        _userReader = userReader;
        Username = username;
    }

    public IList<Error> IsSatisfied()
    {
        var errors = new List<Error>();
        if (_userReader.GetByUsername(Username) != null)
        {
            errors.Add(new Error("002", "sdfdsfsdf"));
        }

        return errors;
    }
}