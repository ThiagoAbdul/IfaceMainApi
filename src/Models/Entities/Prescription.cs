namespace IfaceMainApi.Models.Entities;
public class Prescription : EntityBase
{
    public Guid PatientId { get; set; }
    public virtual PersonWithAlzheimersDisease? Patient { get; set; }
    public Guid MedicineId { get; set; }
    public Medicine? Medicine { get; set; }
    public string Comments { get; set; } = string.Empty;

}
