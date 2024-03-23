using MediatR;
using Microsoft.AspNetCore.Mvc;
using YMYPTask.Application.Features.Auth.Login;

namespace YMYPTask.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public sealed class AuthController(
    IMediator mediator) : ControllerBase
{

    [HttpPost]
    public async Task< IActionResult> Login(LoginCommand request,CancellationToken cancellationToken)
    {
        var response= await mediator.Send(request,cancellationToken);
        return Ok(new {Message=response});
    }
}
