namespace Villsource.SharedKernel;

public class Result : Result<object>
{
    private Result() { }
}
public class Result<TValue> : IResult<TValue>
{
    private TValue? _value;
    private bool _isSuccess;
    private Error? _error;

    public TValue? Value => _value;
    public bool IsSuccess => _isSuccess;
    public Error? Error => _error;

    protected Result(TValue? value)
    {
        _value = value;
        _isSuccess = true;
        _error = default;
    }
    protected Result()
    {
        _value = default;
        _isSuccess = false;
        _error = default;
    }
    protected Result(Error error)
    {
        _value = default;
        _isSuccess = false;
        _error = error;
    }

    public static Result<TValue> Failure() => new(Error.Fail());
    public static Result<TValue> Failure(Error error) => new(error);
    public static Result<TValue> Success() => new() { _isSuccess = true};
    public static Result<TValue> Success(TValue value) => new(value);


    public static implicit operator Result<TValue>(TValue value) => Result.Success(value!);
    public static implicit operator Result<TValue>(Error error) => Result.Failure(error);

    public static implicit operator Result<TValue>(Result<object> result) => new((TValue)result?.Value);
    public static implicit operator Result<TValue>(Result<Result<object>> result) => new((TValue)result?.Value?.Value);
}
