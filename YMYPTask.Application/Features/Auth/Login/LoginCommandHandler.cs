using MediatR;
using Microsoft.AspNetCore.Identity;

namespace YMYPTask.Application.Features.Auth.Login;
internal sealed class LoginCommandHandler(
    UserManager<Appuser> userManager) : IRequestHandler<LoginCommand, string>
{
    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        AppUser? appUser = await userManager.FindByNameAsync(request.UserName);

        if(appUser is null)
        {
            throw new Exception("User not found");
        }

        bool isPasswordTrue = await userManager.CheckPasswordAsync(appUser, request.Password);

        if(!isPasswordTrue)
        {
            throw new Exception("Password is wrong");
        }

        return "User logged in successfully";
    }
}
