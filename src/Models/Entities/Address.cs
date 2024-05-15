namespace IfaceMainApi.Models.Entities;

public class Address : EntityBase
{
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string StreetName { get; set; } = string.Empty;
    public int StreetNumber { get; set; }
    public string? AdministrativeDivision { get; set; }
    public string? Complement { get; set; }
    
}
