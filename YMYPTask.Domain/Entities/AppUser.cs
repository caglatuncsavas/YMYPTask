using Microsoft.AspNetCore.Identity;
using YMYPTask.Domain.Enums;

namespace YMYPTask.Domain.Entities;
public sealed class AppUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => string.Join(" ", FirstName, LastName);
    public UserRole UserRole { get; set; }
}