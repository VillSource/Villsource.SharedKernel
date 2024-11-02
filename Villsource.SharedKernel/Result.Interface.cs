namespace Villsource.SharedKernel;

public interface IResult
{
    bool IsSuccess { get; }
    Error? Error { get; }
}
public interface IResult<out TValue> : IResult
{
    TValue? Value { get; }
}
