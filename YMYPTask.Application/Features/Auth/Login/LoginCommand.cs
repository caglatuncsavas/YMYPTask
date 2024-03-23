using MediatR;

namespace YMYPTask.Application.Features.Auth.Login;
public sealed record LoginCommand(
    string UserName,
    string Password) : IRequest<string>;