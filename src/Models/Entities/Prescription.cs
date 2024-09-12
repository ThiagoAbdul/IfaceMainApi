namespace IfaceMainApi.Models.Entities;
public class Prescription : EntityBase
{
    public Guid PatientId { get; set; }
    public virtual PersonWithAlzheimerDisease? Patient { get; set; }
    public string MedicineName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool Active { get; set; }

    public Prescription()
    {
        
    }

}
