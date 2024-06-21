using IfaceMainApi.Models.Enums;

namespace IfaceMainApi.Models.Entities;

public class Person : EntityBase
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public Guid? MainPhoneId { get; set; }
    public string? MainPhoneNumber { get; set; }
    public string? SecondaryPhoneNumber { get; set; }

}
