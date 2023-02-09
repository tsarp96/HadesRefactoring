using HadesRefactoring.BuildingBlocks;
using HadesRefactoring.User.Rules.SyntacticRules;

namespace HadesRefactoring.User;

public sealed class User
{
    public string Username { get;  private set ; }
    public string Password { get;  private set ; }
    
    
    public User(string username, string password)
    {
        var rules = new List<IRule>()
        {
            new UsernameRule(username),
            new PasswordRule(password),

        };
             
        new SyntacticUserEvaluator(rules).Execute();
        
        Username = username;
        Password = password;
   
    }

    public void SetUsername(string newUsername)
    {
        Username = newUsername;
        
        //Raise Event
    }
    
}