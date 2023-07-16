using Proton.Frequency.Common.Enums;
using Proton.Frequency.Common.Shared;

namespace Proton.Frequency.Common.Entity;

public sealed class User : GroupedEntity {
    public string FullName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Permission Permission { get; set; } = Permission.Standard;
    public string Password { get; set; } = string.Empty;
    public string Salt { get; set; } = string.Empty;
}