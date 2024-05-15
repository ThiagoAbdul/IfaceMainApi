namespace IfaceMainApi.Models.Entities;

public class Credentials : EntityBase
{
    public string Email { get; set; } = string.Empty;
    public string HashPassword { get; set; } = string.Empty;
    public bool HasMfa { get; set; }

}
