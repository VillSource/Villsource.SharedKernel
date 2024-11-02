using MediatR;

namespace Villsource.SharedKernel;

public interface IQuery<TResponse> : IRequest<Result<TResponse>> { }

public interface IQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, Result<TResponse>>
    where TRequest : IQuery<TResponse> { }