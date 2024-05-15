namespace IfaceMainApi.Models.Entities;

public class Caregiver : EntityBase
{
    public Guid PersonId { get; set; }
    public Person? Person { get; set; }    
    public Guid CredentialsId { get; set; }
    public Credentials? Credentials { get; set; }
    public IEnumerable<ClinicCaregiver> ClinicCaregivers { get; set; } = [];
    public IEnumerable<PersonWithAlzheimersDisease> PersonsWithAlzheimerDisease { get; set; } = [];

}
