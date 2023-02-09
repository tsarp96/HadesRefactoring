using HadesRefactoring.BuildingBlocks;

namespace HadesRefactoring.User.Rules.SyntacticRules;

public class UsernameRule : IRule
{
    public string Username { get; set; }
    public UsernameRule(string username)
    {
        Username = username;
    }
    public IList<Error> IsSatisfied()
    {
        var errors = new List<Error>();
        
        if (string.IsNullOrEmpty(Username))
        {
            errors.Add(new Error("001", "Username can not be empty"));
        }

        return errors;
    }
}