namespace HadesRefactoring.BuildingBlocks;

public class Result<T>
{
    public bool IsSuccess { get => !IsFailure; }
    public  List<Error> Errors { get; private set; }
    public bool IsFailure => Errors.Any() ? throw new ArgumentException() : false ; // throw with errors;
    public T Value { get; private set; }

    public Result()
    {
    }
    public static Result<T> Ok(T value)
    {
        var result = new Result<T>();
        result.WithValue(value);
        return result;
    }
    public static Result<T> Fail(List<Error> errors)
    {
        var result = new Result<T>();
        result.WithErrors(errors);
        return result;
    }
    public static Result<T> Create(T value, List<Error> errors)
    {
        var result = new Result<T>();
        result.WithValue(value);
        result.WithErrors(errors);
        return result;
    }
    public Result<T> WithValue(T value)
    {
        Value = value;
        return this;
    }
    
    public Result<T> WithErrors(List<Error> errors)
    {
        var result = new Result<T>();
        Errors = errors;
        return this;
    }
    
    public Result<T> WithError(Error error)
    {
        var result = new Result<T>();
        Errors.Add(error);
        return this;
    }
    
}
