using HadesRefactoring.BuildingBlocks;

namespace HadesRefactoring.User;

public class SyntacticUserEvaluator : Evaluator
{
    public SyntacticUserEvaluator(IEnumerable<IRule> rules) : base(rules)
    {
        
    }
}