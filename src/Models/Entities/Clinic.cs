namespace IfaceMainApi.Models.Entities;

public class Clinic : EntityBase
{
    public string BusinessName { get; set; } = string.Empty;
    public string CorporateName { get; set; } = string.Empty;
    public string TaxId { get; set; } = string.Empty;
    public Guid CredentialsId { get; set; }
    public Credentials? Credentials { get; set; }
    public Guid? MainPhoneNumberId { get; set; }
    public string? MainPhoneNumber { get; set; }
    public string? SecondaryPhoneNumber { get; set; }
    public IEnumerable<ClinicCaregiver> ClinicCaregivers { get; set; } = [];
    public IEnumerable<PersonWithAlzheimersDisease> Patients { get; set; } = [];
}
