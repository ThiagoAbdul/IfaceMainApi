namespace IfaceMainApi.Models.Entities;

public class Caregiver : EntityBase
{

    public Guid PersonId{ get; set; }
    public Person? Person { get; set; }
    public Guid AuthId { get; set; }
    public virtual List<PersonWithAlzheimerDisease> PersonsWithAlzheimerDisease { get; set; } = [];
    public virtual List<Careful> Carefuls { get; set; } = [];

    public Caregiver() { }

}
