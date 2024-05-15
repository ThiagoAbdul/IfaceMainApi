namespace IfaceMainApi.Models.Entities;

public class CaregiverHelp : EntityBase
{
    public Guid SupervisorId { get; set; }
    public Caregiver? Supervisor { get; set; }
    public Guid HelperId { get; set; }
    public Caregiver? Helper { get; set; }
}
