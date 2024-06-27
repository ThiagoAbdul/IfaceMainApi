using IfaceMainApi.Models.Enums;

namespace IfaceMainApi.Models.Entities;
public class PersonWithAlzheimersDisease : EntityBase
{
    public Guid PersonId { get; set; }
    public Person? Person { get; set; }
    public string DeviceToken { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Description { get; set;}
    public AlzheimerStage AlzheimerStage { get; set; }
    public Guid? ClinicId { get; set; }
    public Clinic? Clinic { get; set; }
    public Guid? ResponsibleId { get; set; }
    public Caregiver? Responsible { get; set; }
    public bool IsTheClinicCaredFor { get; set; }
    public DateOnly BirthDate { get; set; }
    public IEnumerable<NonUserSupportPerson> NonUserSupportPeople { get; set; } = [];
    public IEnumerable<Prescription> Prescriptions { get; set; } = [];
    public IEnumerable<Scheduling> Schedules { get; set; } = [];
    
}
