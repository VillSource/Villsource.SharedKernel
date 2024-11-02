namespace Villsource.SharedKernel;

public partial class Error
{
    public ErrorType Type { get; set; } = ErrorType.Failure;
    public string? Code { get; set; }
    public string? Message { get; set; }
}


public partial class Error
{
    public Error() { }
    public Error(string? code, string? message = default, ErrorType type = ErrorType.Failure)
    {
        Type = type;
        Code = code;
        Message = message;
    }

    public static Error Fail(string? code, string? message = default, ErrorType type = ErrorType.Failure) => new(code,message, type);
    public static Error Fail(string? message = default, ErrorType type = ErrorType.Failure) => new(default, message, type);

    public static Error NotFound(string? code, string? message = default) => new(code,message, ErrorType.NotFound);
    public static Error NotFound(string? message = default) => new(default, message, ErrorType.NotFound);
}
