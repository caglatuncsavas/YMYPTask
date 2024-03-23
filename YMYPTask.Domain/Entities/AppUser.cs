using Microsoft.AspNetCore.Identity;
using YMYPTask.Domain.Enums;

namespace YMYPTask.Domain.Entities;
public sealed class AppUser : IdentityUser<Guid>
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public UserRole UserRole { get; set; }
}
