using MediatR;

namespace Villsource.SharedKernel;

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{ }

public interface ICommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, Result<TResponse>>
    where TRequest : ICommand<TResponse> { }

