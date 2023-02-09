namespace HadesRefactoring.BuildingBlocks;

public interface IRule
{
    public IList<Error> IsSatisfied();
}