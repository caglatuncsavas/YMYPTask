using Microsoft.AspNetCore.Identity;
using System.Runtime.ExceptionServices;
using YMYPTask.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if(!userManager.Users.Any())
    {
        AppUser appuser = new()
        {
            FirstName = "Çaðla",
            LastName = "Tunç Savaþ",
            Email = "cagla@gmail.com",
            UserName = "caglatuncsavas"
        };
        userManager.CreateAsync(appuser, "1").Wait();
    }
}

app.Run();
