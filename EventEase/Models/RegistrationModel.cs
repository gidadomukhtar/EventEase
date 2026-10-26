using System.ComponentModel.DataAnnotations;
namespace EventEase.Models;

public sealed class RegistrationModel
{
    [Required, StringLength(60, MinimumLength = 2)] public string FullName { get; set; } = string.Empty;
    [Required, EmailAddress] public string Email { get; set; } = string.Empty;
    [Required] public int? EventId { get; set; }
    [Range(1, 10)] public int NumberOfGuests { get; set; } = 1;
    public bool AcceptTerms { get; set; }
}
