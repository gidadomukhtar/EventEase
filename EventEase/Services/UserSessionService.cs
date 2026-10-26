namespace EventEase.Services;
public sealed class UserSessionService
{
    public string? UserName { get; private set; }
    public string? Email { get; private set; }
    public DateTime? LastRegistrationUtc { get; private set; }
    public bool HasActiveSession => !string.IsNullOrWhiteSpace(Email);
    public void Start(string userName, string email)
    {
        UserName = userName;
        Email = email;
        LastRegistrationUtc = DateTime.UtcNow;
    }
    public void Clear() { UserName = null; Email = null; LastRegistrationUtc = null; }
}
