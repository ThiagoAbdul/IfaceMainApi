namespace IfaceMainApi.Models.Entities;
public class ClinicCaregiver : EntityBase
{
    public Guid ClinicId { get; set; }
    public Clinic? Clinic { get; set; }
    public Guid CaregiverId { get; set; }
    public Caregiver? Caregiver { get; set; }
    
}
