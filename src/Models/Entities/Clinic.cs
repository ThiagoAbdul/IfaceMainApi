namespace IfaceMainApi.Models.Entities;

public class Clinic : EntityBase
{
    public string BusinessName { get; set; } = string.Empty;
    public string CorporateName { get; set; } = string.Empty;
    public string TaxId { get; set; } = string.Empty;
    public Guid CredentialsId { get; set; }
    public Credentials? Credentials { get; set; }
    public Guid? MainPhoneNumberId { get; set; }
    public Phone? MainPhoneNumber { get; set; }
    public Guid? SecondaryPhoneNumberId { get; set; }
    public Phone? SecondaryPhoneNumber { get; set; }
    public Guid AddressId { get; set; }
    public Address? Address { get; set; }
    public IEnumerable<ClinicCaregiver> ClinicCaregivers { get; set; } = [];
    public IEnumerable<PersonWithAlzheimersDisease> Patients { get; set; } = [];
}
