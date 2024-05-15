namespace IfaceMainApi.Models.Entities;

public class Scheduling : EntityBase
{
    public Guid PersonWithAlzheimersDiseaseId { get; set; }
    public PersonWithAlzheimersDisease? PersonWithAlzheimersDisease { get; set; }
    public Guid PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }
    public bool IsMedication { get; set; }
    public string? Description { get; set; }
    public string Cron { get; set; } = string.Empty;
}
