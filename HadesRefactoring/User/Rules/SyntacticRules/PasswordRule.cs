using HadesRefactoring.BuildingBlocks;

namespace HadesRefactoring.User.Rules.SyntacticRules;

public class PasswordRule : IRule
{
    public string Password { get; set; }
    public PasswordRule(string username)
    {
        Password = username;
    }
    public IList<Error> IsSatisfied()
    {
        var errors = new List<Error>();
        
        if (string.IsNullOrEmpty(Password))
        {
            errors.Add(new Error("002", "Password can not be empty"));
        }

        return errors;
    }
}