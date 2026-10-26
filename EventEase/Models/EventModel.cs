using System.ComponentModel.DataAnnotations;
namespace EventEase.Models;

public sealed class EventModel
{
    public int Id { get; set; }
    [Required, StringLength(80, MinimumLength = 3)] public string Name { get; set; } = string.Empty;
    [Required] public DateTime Date { get; set; } = DateTime.Today.AddDays(7);
    [Required, StringLength(120)] public string Location { get; set; } = string.Empty;
    [StringLength(500)] public string Description { get; set; } = string.Empty;
}
