namespace HadesRefactoring.BuildingBlocks;

public abstract class Evaluator
{
    public IEnumerable<IRule> Rules { get; set; }
    public List<Error> Errors { get; set; }

    public Evaluator(IEnumerable<IRule> rules)
    {
        Errors = new List<Error>();
        Rules = rules;
    }
    
    public Evaluator()
    {
        Errors = new List<Error>();
        Rules = new List<IRule>();
    }

    public void Execute()
    {
        Errors = new List<Error>();
        foreach (var rule in Rules)
        {
            Errors.AddRange(rule.IsSatisfied());
        }

        if (Errors.Any()) throw new DomainException(Errors);
    }
}