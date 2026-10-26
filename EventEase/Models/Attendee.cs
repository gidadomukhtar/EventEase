namespace EventEase.Models;
public sealed class Attendee
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int EventId { get; set; }
    public bool IsPresent { get; set; }
}
