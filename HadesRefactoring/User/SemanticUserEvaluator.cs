using System.Data;
using HadesRefactoring.BuildingBlocks;

namespace HadesRefactoring.User;

public class SemanticUserEvaluator : Evaluator
{
    public SemanticUserEvaluator() : base()
    {
        
    }

    public void SetRules(IList<IRule> rules)
    {
        Rules = rules;
    }
}