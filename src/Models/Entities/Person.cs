using IfaceMainApi.Models.Enums;

namespace IfaceMainApi.Models.Entities;

public class Person : EntityBase
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public Guid? MainPhoneId { get; set; }
    public Phone? MainPhone { get; set; }
    public Guid? SecondaryPhoneId { get; set; }
    public Phone? SecondaryPhone { get; set; }
    public Guid? MainAddressId { get; set; }
    public Address? MainAddress { get; set; }
    public Guid? SecondaryAddressId { get; set; }
    public Address? SecondaryAddress { get; set; }
}
