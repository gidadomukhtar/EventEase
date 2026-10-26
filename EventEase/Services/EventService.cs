using EventEase.Models;
namespace EventEase.Services;

public sealed class EventService
{
    private readonly List<EventModel> events =
    [
        new() { Id = 1, Name = "Community Tech Meetup", Date = DateTime.Today.AddDays(14), Location = "Innovation Hub", Description = "A friendly evening of demos, networking, and Blazor discussions." },
        new() { Id = 2, Name = "Design Workshop", Date = DateTime.Today.AddDays(28), Location = "Creative Studio", Description = "A practical workshop on designing accessible event experiences." }
    ];
    private readonly List<Attendee> attendees = [];
    public IReadOnlyList<EventModel> GetEvents() => events;
    public EventModel? GetEvent(int id) => events.FirstOrDefault(e => e.Id == id);
    public IReadOnlyList<Attendee> GetAttendees() => attendees;
    public void Register(RegistrationModel model)
    {
        if (model.EventId is null) return;
        attendees.Add(new Attendee { FullName = model.FullName.Trim(), Email = model.Email.Trim(), EventId = model.EventId.Value });
    }
    public void ToggleAttendance(Guid id)
    {
        var attendee = attendees.FirstOrDefault(a => a.Id == id);
        if (attendee is not null) attendee.IsPresent = !attendee.IsPresent;
    }
}
