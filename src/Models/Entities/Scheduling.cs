namespace IfaceMainApi.Models.Entities;

public class Scheduling : EntityBase
{
    public Guid PersonWithAlzheimersDiseaseId { get; set; }
    public PersonWithAlzheimerDisease? PersonWithAlzheimersDisease { get; set; }
    public Guid PrescriptionId { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime When { get; set; }

    public Scheduling()
    {
        
    }
}
