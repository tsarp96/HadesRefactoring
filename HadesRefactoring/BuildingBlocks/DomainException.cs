namespace HadesRefactoring.BuildingBlocks;

public class DomainException : Exception
{
    public IList<Error> Errors { get; }
    
    public DomainException(IList<Error> errors)
    {
        Errors = errors;
    }
}