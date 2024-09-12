using IfaceMainApi.Models.Enums;

namespace IfaceMainApi.Models.Entities;
public class PersonWithAlzheimerDisease : EntityBase
{
    public Guid PersonId { get; set; }
    public Person? Person { get; set; }
    public string? Description { get; set;}
    public string? DeviceToken { get; set; }
    public AlzheimerStage AlzheimerStage { get; set; }
    public Guid MainCaregiverId { get; set; }
    public Caregiver? MainCaregiver { get; set; }
    public virtual List<KnownPerson> KnownPersons { get; set; } = [];
    public virtual List<Prescription> Prescriptions { get; set; } = [];
    public virtual List<Scheduling> Schedules { get; set; } = [];

    public virtual List<Routine> Routines { get; set; } = [];
    public virtual List<Careful> Carefuls { get; set; } = [];

    public PersonWithAlzheimerDisease()
    {
        
    }


}
